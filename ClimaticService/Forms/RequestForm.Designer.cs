namespace ClimaticService.Forms
{
    partial class RequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelRequest = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxBrokenType = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelRequest
            // 
            this.flowLayoutPanelRequest.AutoScroll = true;
            this.flowLayoutPanelRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRequest.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanelRequest.Name = "flowLayoutPanelRequest";
            this.flowLayoutPanelRequest.Size = new System.Drawing.Size(417, 617);
            this.flowLayoutPanelRequest.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(417, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 617);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxBrokenType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // listBoxBrokenType
            // 
            this.listBoxBrokenType.FormattingEnabled = true;
            this.listBoxBrokenType.ItemHeight = 15;
            this.listBoxBrokenType.Location = new System.Drawing.Point(22, 82);
            this.listBoxBrokenType.Name = "listBoxBrokenType";
            this.listBoxBrokenType.Size = new System.Drawing.Size(194, 109);
            this.listBoxBrokenType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Типы неисправности:";
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Location = new System.Drawing.Point(185, 37);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(38, 15);
            this.labelAll.TabIndex = 2;
            this.labelAll.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во выполненых заявок:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(67, 231);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 42);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить заявку";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 617);
            this.Controls.Add(this.flowLayoutPanelRequest);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RequestForm";
            this.Text = "Заявки на ремонт";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBrokenType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Label label1;
    }
}