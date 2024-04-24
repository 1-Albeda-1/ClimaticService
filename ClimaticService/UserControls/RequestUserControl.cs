using ClimaticService.Context;
using ClimaticService.Context.DB;
using ClimaticService.Context.Models;
using ClimaticService.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimaticService
{
    public partial class RequestUserControl : UserControl
    {
        public Request Request { get; set; }
        public Action UpdateStatus; 
        public RequestUserControl(Request request)
        {
            InitializeComponent();
            InitializeRequest(request);
            comboBoxBroken.DisplayMember = nameof(BrokenType.BrokenTypeTitle);
            comboBoxEquipment.DisplayMember = nameof(EquipmentType.EquipmentTypeTitle);
            comboBoxStatus.DisplayMember = nameof(Status.StatusTitle);
            comboBoxWorker.DisplayMember = nameof(User.FullName);
        }

        /// <summary>
        /// Отображение данных о заявке в элементы управления
        /// </summary>
        private void InitializeRequest(Request request)
        {
            Request = request;
            using(var db = new ClimaticServiceContext())
            {
                Request = db.Requests
                    .Include(x => x.Worker)
                    .Include(x => x.EquipmentType)
                    .Include(x => x.Status)
                    .Include(x => x.Client)
                    .Include(x => x.BrokenType)
                    .FirstOrDefault(x => x.IdRequest == Request.IdRequest);

                comboBoxBroken.Items.AddRange(db.BrokenTypes.ToArray());
                comboBoxEquipment.Items.AddRange(db.EquipmentTypes.ToArray());
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());
                comboBoxWorker.Items.AddRange(db.Users.Where(x => x.RoleId == 3).ToArray());
            }

            if(Request != null)
            {
                labelClient.Text = Request.Client.FullName;
                labelDateAdd.Text = Request.DateAdd.ToString("dd-MM-yyyy");                
                labelNumber.Text = Request.IdRequest.ToString();
                labelPhone.Text = Request.Client.Phone;
                textBoxModel.Text = Request.EquipmentModel;
                richTextBoxDescription.Text = Request.Description;
                richTextBoxSpares.Text = Request.Spares;
                comboBoxBroken.SelectedItem = comboBoxBroken.Items.Cast<BrokenType>().FirstOrDefault(x => x.IdBrokenType == Request.BrokenTypeId);
                comboBoxEquipment.SelectedItem = comboBoxEquipment.Items.Cast<EquipmentType>().FirstOrDefault(x => x.IdEquipmentType == Request.EquipmentTypeId);
                comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>().FirstOrDefault(x => x.IdStatus == Request.StatusId);
                comboBoxWorker.SelectedItem = comboBoxWorker.Items.Cast<User>().FirstOrDefault(x => x.IdUser == Request.WorkerId);
                if(Request.StatusId == 1)
                {
                    labelDateClosing.Text = Request.DateClose?.ToString("dd-MM-yyyy");
                    this.BackColor = Color.Gray;
                }
            }
            buttonSave.Enabled = WorkToUser.User.RoleId != 3 &&  WorkToUser.User.RoleId != 4;
            groupBoxClient.Enabled = WorkToUser.User.RoleId == 1;
            groupBoxOperator.Enabled = WorkToUser.User.RoleId == 2;
        }

        /// <summary>
        /// Сохранение изменений заявки
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxModel.Text) && !string.IsNullOrEmpty(richTextBoxDescription.Text))
            {
                using (var db = new ClimaticServiceContext())
                {
                    var request = db.Requests.FirstOrDefault(x => x.IdRequest == Request.IdRequest);
                    if(request != null)
                    {
                        if (comboBoxWorker.SelectedItem != null)
                        {
                            request.WorkerId = ((User)comboBoxWorker.SelectedItem).IdUser;
                            request.StatusId = 2;
                            comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>().FirstOrDefault(x => x.IdStatus == request.StatusId);
                        }
                        request.Spares = richTextBoxSpares.Text;
                        request.Description = richTextBoxDescription.Text;
                        request.EquipmentModel = textBoxModel.Text;      
                        request.EquipmentTypeId = ((EquipmentType)comboBoxEquipment.SelectedItem).IdEquipmentType;
                        request.BrokenTypeId = ((BrokenType)comboBoxBroken.SelectedItem).IdBrokenType;
                        request.StatusId = ((Status)comboBoxStatus.SelectedItem).IdStatus;
                        if(request.StatusId == 1)
                        {
                            request.DateClose = DateTime.Now;
                            this.BackColor = Color.Gray;
                            MessageBox.Show($"Заявка {request.IdRequest} готова к выдаче!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"Заявка {request.IdRequest} сохранена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
                        InitializeRequest(request);
                        UpdateStatus?.Invoke();
                    }
                }
            }
            else
                MessageBox.Show("Заполните все поля перед сохранением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
