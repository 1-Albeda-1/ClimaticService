namespace ClimaticService
{
    partial class RequestUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.labelDateAdd = new System.Windows.Forms.Label();
            this.comboBoxBroken = new System.Windows.Forms.ComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxOperator = new System.Windows.Forms.GroupBox();
            this.richTextBoxSpares = new System.Windows.Forms.RichTextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDateClosing = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата добавления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ФИО клиента:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер телеофона:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(354, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные клиента";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(149, 65);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(43, 15);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "label13";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(149, 32);
            this.labelClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(38, 15);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "label9";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.labelDateAdd);
            this.groupBoxClient.Controls.Add(this.comboBoxBroken);
            this.groupBoxClient.Controls.Add(this.labelNumber);
            this.groupBoxClient.Controls.Add(this.label9);
            this.groupBoxClient.Controls.Add(this.label2);
            this.groupBoxClient.Controls.Add(this.textBoxModel);
            this.groupBoxClient.Controls.Add(this.label1);
            this.groupBoxClient.Controls.Add(this.comboBoxEquipment);
            this.groupBoxClient.Controls.Add(this.richTextBoxDescription);
            this.groupBoxClient.Controls.Add(this.label15);
            this.groupBoxClient.Controls.Add(this.label13);
            this.groupBoxClient.Controls.Add(this.label14);
            this.groupBoxClient.Location = new System.Drawing.Point(15, 24);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxClient.Size = new System.Drawing.Size(354, 312);
            this.groupBoxClient.TabIndex = 8;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Данные по заявке";
            // 
            // labelDateAdd
            // 
            this.labelDateAdd.AutoSize = true;
            this.labelDateAdd.Location = new System.Drawing.Point(139, 62);
            this.labelDateAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateAdd.Name = "labelDateAdd";
            this.labelDateAdd.Size = new System.Drawing.Size(38, 15);
            this.labelDateAdd.TabIndex = 8;
            this.labelDateAdd.Text = "label9";
            // 
            // comboBoxBroken
            // 
            this.comboBoxBroken.FormattingEnabled = true;
            this.comboBoxBroken.Location = new System.Drawing.Point(142, 123);
            this.comboBoxBroken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxBroken.Name = "comboBoxBroken";
            this.comboBoxBroken.Size = new System.Drawing.Size(181, 23);
            this.comboBoxBroken.TabIndex = 36;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(139, 35);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(48, 13);
            this.labelNumber.TabIndex = 8;
            this.labelNumber.Text = "label14";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Тип поломки:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(142, 158);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(181, 23);
            this.textBoxModel.TabIndex = 34;
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(142, 88);
            this.comboBoxEquipment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(181, 23);
            this.comboBoxEquipment.TabIndex = 33;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(142, 192);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(181, 103);
            this.richTextBoxDescription.TabIndex = 32;
            this.richTextBoxDescription.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 161);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Модель оборудования:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 195);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Описание проблемы:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Тип оборудования:";
            // 
            // groupBoxOperator
            // 
            this.groupBoxOperator.Controls.Add(this.richTextBoxSpares);
            this.groupBoxOperator.Controls.Add(this.comboBoxStatus);
            this.groupBoxOperator.Controls.Add(this.comboBoxWorker);
            this.groupBoxOperator.Controls.Add(this.label8);
            this.groupBoxOperator.Controls.Add(this.labelDateClosing);
            this.groupBoxOperator.Controls.Add(this.label10);
            this.groupBoxOperator.Controls.Add(this.label11);
            this.groupBoxOperator.Controls.Add(this.label12);
            this.groupBoxOperator.Location = new System.Drawing.Point(15, 447);
            this.groupBoxOperator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxOperator.Name = "groupBoxOperator";
            this.groupBoxOperator.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxOperator.Size = new System.Drawing.Size(354, 180);
            this.groupBoxOperator.TabIndex = 9;
            this.groupBoxOperator.TabStop = false;
            this.groupBoxOperator.Text = "Данные для оператора";
            // 
            // richTextBoxSpares
            // 
            this.richTextBoxSpares.Location = new System.Drawing.Point(146, 22);
            this.richTextBoxSpares.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxSpares.Name = "richTextBoxSpares";
            this.richTextBoxSpares.Size = new System.Drawing.Size(180, 42);
            this.richTextBoxSpares.TabIndex = 13;
            this.richTextBoxSpares.Text = "";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(146, 77);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(180, 23);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(146, 106);
            this.comboBoxWorker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(180, 23);
            this.comboBoxWorker.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Запчасти:";
            // 
            // labelDateClosing
            // 
            this.labelDateClosing.AutoSize = true;
            this.labelDateClosing.Location = new System.Drawing.Point(143, 143);
            this.labelDateClosing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateClosing.Name = "labelDateClosing";
            this.labelDateClosing.Size = new System.Drawing.Size(72, 15);
            this.labelDateClosing.TabIndex = 16;
            this.labelDateClosing.Text = "Отсутствует";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Статус:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Мастер:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Дата завершения:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(125, 633);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 43);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxOperator);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(385, 696);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxOperator.ResumeLayout(false);
            this.groupBoxOperator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.GroupBox groupBoxOperator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDateClosing;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.RichTextBox richTextBoxSpares;
        private System.Windows.Forms.Label labelDateAdd;
        private System.Windows.Forms.ComboBox comboBoxBroken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonSave;
    }
}
