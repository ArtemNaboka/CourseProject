namespace CourseProject
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTStrM = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.pravkaTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOfEmpTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmporiumTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.findEmporiumTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmporiumTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmporiumTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.informationTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.ownCB = new System.Windows.Forms.ComboBox();
            this.specCB = new System.Windows.Forms.ComboBox();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.finishDTP = new System.Windows.Forms.DateTimePicker();
            this.useTimeChB = new System.Windows.Forms.CheckBox();
            this.timePanel = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fullInfoCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.editCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formOfOwnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.timePanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.pravkaTMS,
            this.informationTMS});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(699, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTStrM,
            this.exitTMS});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveTStrM
            // 
            this.saveTStrM.Name = "saveTStrM";
            this.saveTStrM.Size = new System.Drawing.Size(132, 22);
            this.saveTStrM.Text = "Сохранить";
            this.saveTStrM.Click += new System.EventHandler(this.saveTStrM_Click);
            // 
            // exitTMS
            // 
            this.exitTMS.Name = "exitTMS";
            this.exitTMS.Size = new System.Drawing.Size(132, 22);
            this.exitTMS.Text = "Выход";
            this.exitTMS.Click += new System.EventHandler(this.exitTMS_Click);
            // 
            // pravkaTMS
            // 
            this.pravkaTMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoOfEmpTMS,
            this.AddEmporiumTMS,
            this.findEmporiumTMS,
            this.editEmporiumTMS,
            this.deleteEmporiumTMS});
            this.pravkaTMS.Name = "pravkaTMS";
            this.pravkaTMS.Size = new System.Drawing.Size(59, 20);
            this.pravkaTMS.Text = "Правка";
            // 
            // infoOfEmpTMS
            // 
            this.infoOfEmpTMS.Name = "infoOfEmpTMS";
            this.infoOfEmpTMS.Size = new System.Drawing.Size(154, 22);
            this.infoOfEmpTMS.Text = "Просмотреть";
            this.infoOfEmpTMS.Click += new System.EventHandler(this.infoOfEmp_Click);
            // 
            // AddEmporiumTMS
            // 
            this.AddEmporiumTMS.Name = "AddEmporiumTMS";
            this.AddEmporiumTMS.Size = new System.Drawing.Size(154, 22);
            this.AddEmporiumTMS.Text = "Добавить";
            this.AddEmporiumTMS.Click += new System.EventHandler(this.AddEmporiumCMS_Click);
            // 
            // findEmporiumTMS
            // 
            this.findEmporiumTMS.Name = "findEmporiumTMS";
            this.findEmporiumTMS.Size = new System.Drawing.Size(154, 22);
            this.findEmporiumTMS.Text = "Найти";
            this.findEmporiumTMS.Click += new System.EventHandler(this.findEmporiumCMS_Click);
            // 
            // editEmporiumTMS
            // 
            this.editEmporiumTMS.Name = "editEmporiumTMS";
            this.editEmporiumTMS.Size = new System.Drawing.Size(154, 22);
            this.editEmporiumTMS.Text = "Редактировать";
            this.editEmporiumTMS.Click += new System.EventHandler(this.editEmporiumCMS_Click);
            // 
            // deleteEmporiumTMS
            // 
            this.deleteEmporiumTMS.Name = "deleteEmporiumTMS";
            this.deleteEmporiumTMS.Size = new System.Drawing.Size(154, 22);
            this.deleteEmporiumTMS.Text = "Удалить";
            this.deleteEmporiumTMS.Click += new System.EventHandler(this.deleteEmporiumCMS_Click);
            // 
            // informationTMS
            // 
            this.informationTMS.Name = "informationTMS";
            this.informationTMS.Size = new System.Drawing.Size(94, 20);
            this.informationTMS.Text = "О программе";
            this.informationTMS.Click += new System.EventHandler(this.informationTMS_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск торговых точек города";
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AutoGenerateColumns = false;
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.formOfOwnDataGridViewTextBoxColumn});
            this.dataGV.DataSource = this.BindSource;
            this.dataGV.Location = new System.Drawing.Point(12, 270);
            this.dataGV.Name = "dataGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(675, 172);
            this.dataGV.TabIndex = 14;
            this.dataGV.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGV_CellContextMenuStripNeeded);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(122, 87);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(163, 22);
            this.nameTB.TabIndex = 15;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(122, 126);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(163, 22);
            this.addressTB.TabIndex = 16;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(122, 166);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(163, 22);
            this.phoneTB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Специализация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Форма собственности";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(526, 230);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(104, 34);
            this.findBtn.TabIndex = 25;
            this.findBtn.Text = "Найти";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // ownCB
            // 
            this.ownCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownCB.Items.AddRange(new object[] {
            "Любая",
            "Частная",
            "Государственная",
            "Муниципальная"});
            this.ownCB.Location = new System.Drawing.Point(497, 126);
            this.ownCB.Name = "ownCB";
            this.ownCB.Size = new System.Drawing.Size(161, 24);
            this.ownCB.TabIndex = 26;
            // 
            // specCB
            // 
            this.specCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specCB.FormattingEnabled = true;
            this.specCB.Items.AddRange(new object[] {
            "Любая",
            "Электроника",
            "Промышленность",
            "Сельское хозяйство",
            "Одежда и обувь",
            "Бытовой магазин",
            "Супермаркет",
            "Торговый центр",
            "Другое"});
            this.specCB.Location = new System.Drawing.Point(497, 87);
            this.specCB.Name = "specCB";
            this.specCB.Size = new System.Drawing.Size(161, 24);
            this.specCB.TabIndex = 27;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(400, 230);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(106, 34);
            this.showAllBtn.TabIndex = 28;
            this.showAllBtn.Text = "Показать все";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click_2);
            // 
            // startDTP
            // 
            this.startDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDTP.CustomFormat = "HH:mm";
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(127, 5);
            this.startDTP.MaximumSize = new System.Drawing.Size(500, 100);
            this.startDTP.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTP.Name = "startDTP";
            this.startDTP.ShowUpDown = true;
            this.startDTP.Size = new System.Drawing.Size(54, 22);
            this.startDTP.TabIndex = 105;
            this.startDTP.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 106;
            this.label7.Text = "Время работы";
            // 
            // finishDTP
            // 
            this.finishDTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finishDTP.CustomFormat = "HH:mm";
            this.finishDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishDTP.Location = new System.Drawing.Point(210, 4);
            this.finishDTP.MaximumSize = new System.Drawing.Size(500, 100);
            this.finishDTP.MinDate = new System.DateTime(1800, 1, 1, 0, 1, 0, 0);
            this.finishDTP.Name = "finishDTP";
            this.finishDTP.ShowUpDown = true;
            this.finishDTP.Size = new System.Drawing.Size(56, 22);
            this.finishDTP.TabIndex = 107;
            this.finishDTP.Value = new System.DateTime(1800, 1, 1, 23, 59, 0, 0);
            // 
            // useTimeChB
            // 
            this.useTimeChB.AutoSize = true;
            this.useTimeChB.Location = new System.Drawing.Point(380, 168);
            this.useTimeChB.Name = "useTimeChB";
            this.useTimeChB.Size = new System.Drawing.Size(141, 20);
            this.useTimeChB.TabIndex = 108;
            this.useTimeChB.Text = "Учитывать время";
            this.useTimeChB.UseVisualStyleBackColor = true;
            this.useTimeChB.CheckedChanged += new System.EventHandler(this.useTimeChB_CheckedChanged);
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.finishDTP);
            this.timePanel.Controls.Add(this.startDTP);
            this.timePanel.Controls.Add(this.label7);
            this.timePanel.Enabled = false;
            this.timePanel.Location = new System.Drawing.Point(367, 195);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(278, 29);
            this.timePanel.TabIndex = 109;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullInfoCMS,
            this.editCMS,
            this.removeCMS});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(155, 70);
            // 
            // fullInfoCMS
            // 
            this.fullInfoCMS.Name = "fullInfoCMS";
            this.fullInfoCMS.Size = new System.Drawing.Size(154, 22);
            this.fullInfoCMS.Text = "Просмотреть";
            this.fullInfoCMS.Click += new System.EventHandler(this.fullInfoCMS_Click);
            // 
            // editCMS
            // 
            this.editCMS.Name = "editCMS";
            this.editCMS.Size = new System.Drawing.Size(154, 22);
            this.editCMS.Text = "Редактировать";
            this.editCMS.Click += new System.EventHandler(this.editCMS_Click);
            // 
            // removeCMS
            // 
            this.removeCMS.Name = "removeCMS";
            this.removeCMS.Size = new System.Drawing.Size(154, 22);
            this.removeCMS.Text = "Удалить";
            this.removeCMS.Click += new System.EventHandler(this.removeCMS_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Специализация";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formOfOwnDataGridViewTextBoxColumn
            // 
            this.formOfOwnDataGridViewTextBoxColumn.DataPropertyName = "FormOfOwn";
            this.formOfOwnDataGridViewTextBoxColumn.HeaderText = "Форма собственности";
            this.formOfOwnDataGridViewTextBoxColumn.Name = "formOfOwnDataGridViewTextBoxColumn";
            this.formOfOwnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindSource
            // 
            this.BindSource.DataSource = typeof(CourseProject.Model.Emporium);
            // 
            // MajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 469);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.useTimeChB);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.specCB);
            this.Controls.Add(this.ownCB);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MajorForm";
            this.Text = "Справочник покупателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTMS;
        private System.Windows.Forms.ToolStripMenuItem pravkaTMS;
        private System.Windows.Forms.ToolStripMenuItem informationTMS;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.BindingSource BindSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem AddEmporiumTMS;
        private System.Windows.Forms.ToolStripMenuItem findEmporiumTMS;
        private System.Windows.Forms.ToolStripMenuItem editEmporiumTMS;
        private System.Windows.Forms.ToolStripMenuItem deleteEmporiumTMS;
        private System.Windows.Forms.ToolStripMenuItem saveTStrM;
        public System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ownCB;
        private System.Windows.Forms.ComboBox specCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formOfOwnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.ToolStripMenuItem infoOfEmpTMS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.DateTimePicker finishDTP;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.CheckBox useTimeChB;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem fullInfoCMS;
        private System.Windows.Forms.ToolStripMenuItem editCMS;
        private System.Windows.Forms.ToolStripMenuItem removeCMS;
    }
}

