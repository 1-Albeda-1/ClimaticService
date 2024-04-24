using ClimaticService.Context.DB;
using ClimaticService.Context.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ClimaticService.Forms
{
    public partial class RequestForm : Form
    {
        private int completedRequest = 0;
    
        public RequestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление 
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(var db = new ClimaticServiceContext())
            {
                var request = new Request()
                {
                    StatusId = 4,
                    DateAdd = DateTime.Now,
                    EquipmentTypeId = 1,
                    ClientId = WorkToUser.User.IdUser,
                };
                db.Requests.Add(request);
                db.SaveChanges();
                var control = new RequestUserControl(request);
                control.Parent = flowLayoutPanelRequest;
            }
           
        }

        /// <summary>
        /// Отображение заявок в зависимости от роли 
        /// </summary>
        private void RequestForm_Load(object sender, EventArgs e)
        {
            List<Request> requests;
            using (var db = new ClimaticServiceContext())
            {
                switch (WorkToUser.User.RoleId)
                {
                    case 1:
                        requests = db.Requests.Where(x => x.ClientId == WorkToUser.User.IdUser).ToList();
                        break;
                    case 3:
                        requests = db.Requests.Where(x => x.WorkerId == WorkToUser.User.IdUser).ToList();
                        break;
                    default:
                        requests = db.Requests.ToList();
                        break;
                }

                foreach (var request in requests)
                {
                    var control = new RequestUserControl(request);
                    control.Parent = flowLayoutPanelRequest;
                    control.UpdateStatus += CompletedRequestsAndList;
                }
            }
            CompletedRequestsAndList();
            buttonAdd.Enabled = WorkToUser.User.RoleId == 1;
                
        }

        /// <summary>
        /// Подсчет кол-ва завершенных заявок и Статистика по неисправностям
        /// </summary>
        private void CompletedRequestsAndList()
        {
            completedRequest = 0;
            listBoxBrokenType.Items.Clear();
            var dictionaryBroken = new Dictionary<string, int>();
            foreach(var item in flowLayoutPanelRequest.Controls)
            {
                if(item is RequestUserControl control)
                {
                    if(control.Request.BrokenTypeId != null)
                    {
                        if(dictionaryBroken.TryGetValue(control.Request.BrokenType.BrokenTypeTitle, out var Count))
                        {
                            dictionaryBroken[control.Request.BrokenType.BrokenTypeTitle] = ++Count;
                        }
                        else
                        {
                            dictionaryBroken.Add(control.Request.BrokenType.BrokenTypeTitle, 1);
                        }
                    }
                    
                    if (control.Request.StatusId == 1)
                    {
                        completedRequest++;
                    }
                }
            }
            if(dictionaryBroken.Count != 0)
            {
                foreach(var item in dictionaryBroken)
                {
                    listBoxBrokenType.Items.Add($"{item.Key}: {item.Value}");

                }
            }
            labelAll.Text = completedRequest.ToString();
        }
    }
}
