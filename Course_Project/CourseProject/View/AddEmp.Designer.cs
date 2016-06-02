namespace CourseProject
{
    partial class AddEmp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.finishDTP = new System.Windows.Forms.DateTimePicker();
            this.specBoxCB = new System.Windows.Forms.ComboBox();
            this.ownBoxCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thirdDigsTB = new System.Windows.Forms.TextBox();
            this.secondDigsTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstDigsTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressOfEmpTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameOfEmpTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.startDTP);
            this.panel1.Controls.Add(this.finishDTP);
            this.panel1.Controls.Add(this.specBoxCB);
            this.panel1.Controls.Add(this.ownBoxCB);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.thirdDigsTB);
            this.panel1.Controls.Add(this.secondDigsTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.firstDigsTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addressOfEmpTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameOfEmpTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 250);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 106;
            this.label14.Text = "Конец";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 105;
            this.label13.Text = "Начало";
            // 
            // startDTP
            // 
            this.startDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDTP.CustomFormat = "HH:mm";
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(193, 169);
            this.startDTP.MaximumSize = new System.Drawing.Size(500, 100);
            this.startDTP.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTP.Name = "startDTP";
            this.startDTP.ShowUpDown = true;
            this.startDTP.Size = new System.Drawing.Size(54, 20);
            this.startDTP.TabIndex = 104;
            this.startDTP.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // finishDTP
            // 
            this.finishDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finishDTP.CustomFormat = "HH:mm";
            this.finishDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishDTP.Location = new System.Drawing.Point(329, 169);
            this.finishDTP.MaximumSize = new System.Drawing.Size(500, 100);
            this.finishDTP.MinDate = new System.DateTime(1800, 1, 1, 0, 1, 0, 0);
            this.finishDTP.Name = "finishDTP";
            this.finishDTP.ShowUpDown = true;
            this.finishDTP.Size = new System.Drawing.Size(50, 20);
            this.finishDTP.TabIndex = 103;
            this.finishDTP.Value = new System.DateTime(1800, 1, 1, 23, 59, 0, 0);
            // 
            // specBoxCB
            // 
            this.specBoxCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specBoxCB.FormattingEnabled = true;
            this.specBoxCB.Items.AddRange(new object[] {
            "Электроника",
            "Промышленность",
            "Сельское хозяйство",
            "Одежда и обувь",
            "Бытовой магазин",
            "Супермаркет",
            "Торговый центр",
            "Другое"});
            this.specBoxCB.Location = new System.Drawing.Point(150, 102);
            this.specBoxCB.Name = "specBoxCB";
            this.specBoxCB.Size = new System.Drawing.Size(156, 21);
            this.specBoxCB.TabIndex = 25;
            // 
            // ownBoxCB
            // 
            this.ownBoxCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownBoxCB.FormattingEnabled = true;
            this.ownBoxCB.Items.AddRange(new object[] {
            "Государственная",
            "Муниципальная",
            "Частная"});
            this.ownBoxCB.Location = new System.Drawing.Point(150, 77);
            this.ownBoxCB.Name = "ownBoxCB";
            this.ownBoxCB.Size = new System.Drawing.Size(156, 21);
            this.ownBoxCB.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Форма собственности :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Специализация :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Время работы :";
            // 
            // thirdDigsTB
            // 
            this.thirdDigsTB.Location = new System.Drawing.Point(285, 131);
            this.thirdDigsTB.MaxLength = 2;
            this.thirdDigsTB.Name = "thirdDigsTB";
            this.thirdDigsTB.Size = new System.Drawing.Size(21, 20);
            this.thirdDigsTB.TabIndex = 10;
            // 
            // secondDigsTB
            // 
            this.secondDigsTB.Location = new System.Drawing.Point(239, 131);
            this.secondDigsTB.MaxLength = 2;
            this.secondDigsTB.Name = "secondDigsTB";
            this.secondDigsTB.Size = new System.Drawing.Size(23, 20);
            this.secondDigsTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // firstDigsTB
            // 
            this.firstDigsTB.Location = new System.Drawing.Point(193, 131);
            this.firstDigsTB.MaxLength = 3;
            this.firstDigsTB.Name = "firstDigsTB";
            this.firstDigsTB.Size = new System.Drawing.Size(24, 20);
            this.firstDigsTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "+38(057)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер :";
            // 
            // addressOfEmpTB
            // 
            this.addressOfEmpTB.Location = new System.Drawing.Point(150, 37);
            this.addressOfEmpTB.Name = "addressOfEmpTB";
            this.addressOfEmpTB.Size = new System.Drawing.Size(186, 20);
            this.addressOfEmpTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес :";
            // 
            // nameOfEmpTB
            // 
            this.nameOfEmpTB.Location = new System.Drawing.Point(150, 8);
            this.nameOfEmpTB.Name = "nameOfEmpTB";
            this.nameOfEmpTB.Size = new System.Drawing.Size(186, 20);
            this.nameOfEmpTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название :";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(341, 293);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(28, 293);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Назад";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(472, 342);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmp";
            this.Text = "Добавить торговую точку";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameOfEmpTB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressOfEmpTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox thirdDigsTB;
        private System.Windows.Forms.TextBox secondDigsTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstDigsTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox specBoxCB;
        private System.Windows.Forms.ComboBox ownBoxCB;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.DateTimePicker finishDTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}