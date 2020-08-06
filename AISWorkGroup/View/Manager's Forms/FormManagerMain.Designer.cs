namespace AISWorkGroup.View.Manager_s_Forms
{
    partial class FormManagerMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.buttonDeleteSelectedEmployee = new System.Windows.Forms.Button();
            this.buttonInformationAboutSelectedEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployeesList = new System.Windows.Forms.DataGridView();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageWorkingGroups = new System.Windows.Forms.TabPage();
            this.buttonDeleteSelectedWorkGroup = new System.Windows.Forms.Button();
            this.buttonGoToSelectedWorkGroup = new System.Windows.Forms.Button();
            this.buttonEditSelectedWorkGroup = new System.Windows.Forms.Button();
            this.buttonAddNewWorkGroup = new System.Windows.Forms.Button();
            this.dataGridViewWorkGroupsList = new System.Windows.Forms.DataGridView();
            this.ColumnTitile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescroption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPagePersonalInformation = new System.Windows.Forms.TabPage();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonRenewPersonalInformation = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesList)).BeginInit();
            this.tabPageWorkingGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkGroupsList)).BeginInit();
            this.tabPagePersonalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployees);
            this.tabControl1.Controls.Add(this.tabPageWorkingGroups);
            this.tabControl1.Controls.Add(this.tabPagePersonalInformation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.buttonDeleteSelectedEmployee);
            this.tabPageEmployees.Controls.Add(this.buttonInformationAboutSelectedEmployee);
            this.tabPageEmployees.Controls.Add(this.dataGridViewEmployeesList);
            this.tabPageEmployees.Controls.Add(this.label1);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(792, 424);
            this.tabPageEmployees.TabIndex = 0;
            this.tabPageEmployees.Text = "Сотрудники";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelectedEmployee
            // 
            this.buttonDeleteSelectedEmployee.Location = new System.Drawing.Point(66, 393);
            this.buttonDeleteSelectedEmployee.Name = "buttonDeleteSelectedEmployee";
            this.buttonDeleteSelectedEmployee.Size = new System.Drawing.Size(661, 23);
            this.buttonDeleteSelectedEmployee.TabIndex = 3;
            this.buttonDeleteSelectedEmployee.Text = "Удалить выбранного сотрудника";
            this.buttonDeleteSelectedEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedEmployee.Click += new System.EventHandler(this.buttonDeleteSelectedEmployee_Click);
            // 
            // buttonInformationAboutSelectedEmployee
            // 
            this.buttonInformationAboutSelectedEmployee.Location = new System.Drawing.Point(66, 364);
            this.buttonInformationAboutSelectedEmployee.Name = "buttonInformationAboutSelectedEmployee";
            this.buttonInformationAboutSelectedEmployee.Size = new System.Drawing.Size(661, 23);
            this.buttonInformationAboutSelectedEmployee.TabIndex = 2;
            this.buttonInformationAboutSelectedEmployee.Text = "Подробная информация о выбранном сотруднике";
            this.buttonInformationAboutSelectedEmployee.UseVisualStyleBackColor = true;
            this.buttonInformationAboutSelectedEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEmployeesList
            // 
            this.dataGridViewEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPosition,
            this.ColumnFullName,
            this.ColumnDateOfBirth,
            this.ColumnPhoneNumber,
            this.ColumnEmail});
            this.dataGridViewEmployeesList.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewEmployeesList.Name = "dataGridViewEmployeesList";
            this.dataGridViewEmployeesList.Size = new System.Drawing.Size(776, 323);
            this.dataGridViewEmployeesList.TabIndex = 1;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.FillWeight = 150F;
            this.ColumnPosition.HeaderText = "Должность";
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.Width = 125;
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.FillWeight = 200F;
            this.ColumnFullName.HeaderText = "ФИО";
            this.ColumnFullName.Name = "ColumnFullName";
            this.ColumnFullName.Width = 200;
            // 
            // ColumnDateOfBirth
            // 
            this.ColumnDateOfBirth.HeaderText = "Дата рождения";
            this.ColumnDateOfBirth.Name = "ColumnDateOfBirth";
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.FillWeight = 150F;
            this.ColumnPhoneNumber.HeaderText = "Телефон";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.Width = 150;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.FillWeight = 150F;
            this.ColumnEmail.HeaderText = "E-Mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список сотрудников";
            // 
            // tabPageWorkingGroups
            // 
            this.tabPageWorkingGroups.Controls.Add(this.buttonDeleteSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.buttonGoToSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.buttonEditSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.buttonAddNewWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.dataGridViewWorkGroupsList);
            this.tabPageWorkingGroups.Controls.Add(this.label2);
            this.tabPageWorkingGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkingGroups.Name = "tabPageWorkingGroups";
            this.tabPageWorkingGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkingGroups.Size = new System.Drawing.Size(792, 424);
            this.tabPageWorkingGroups.TabIndex = 1;
            this.tabPageWorkingGroups.Text = "Рабочие группы";
            this.tabPageWorkingGroups.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelectedWorkGroup
            // 
            this.buttonDeleteSelectedWorkGroup.Location = new System.Drawing.Point(426, 391);
            this.buttonDeleteSelectedWorkGroup.Name = "buttonDeleteSelectedWorkGroup";
            this.buttonDeleteSelectedWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonDeleteSelectedWorkGroup.TabIndex = 9;
            this.buttonDeleteSelectedWorkGroup.Text = "Удалить выбранную рабочую группу";
            this.buttonDeleteSelectedWorkGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedWorkGroup.Click += new System.EventHandler(this.buttonDeleteSelectedWorkGroup_Click);
            // 
            // buttonGoToSelectedWorkGroup
            // 
            this.buttonGoToSelectedWorkGroup.Location = new System.Drawing.Point(426, 362);
            this.buttonGoToSelectedWorkGroup.Name = "buttonGoToSelectedWorkGroup";
            this.buttonGoToSelectedWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonGoToSelectedWorkGroup.TabIndex = 8;
            this.buttonGoToSelectedWorkGroup.Text = "Перейти к выбранной рабочей группе";
            this.buttonGoToSelectedWorkGroup.UseVisualStyleBackColor = true;
            this.buttonGoToSelectedWorkGroup.Click += new System.EventHandler(this.buttonGoToSelectedWorkGroup_Click);
            // 
            // buttonEditSelectedWorkGroup
            // 
            this.buttonEditSelectedWorkGroup.Location = new System.Drawing.Point(65, 391);
            this.buttonEditSelectedWorkGroup.Name = "buttonEditSelectedWorkGroup";
            this.buttonEditSelectedWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonEditSelectedWorkGroup.TabIndex = 7;
            this.buttonEditSelectedWorkGroup.Text = "Изменить выбранную рабочую группу";
            this.buttonEditSelectedWorkGroup.UseVisualStyleBackColor = true;
            this.buttonEditSelectedWorkGroup.Click += new System.EventHandler(this.buttonEditSelectedWorkGroup_Click);
            // 
            // buttonAddNewWorkGroup
            // 
            this.buttonAddNewWorkGroup.Location = new System.Drawing.Point(65, 362);
            this.buttonAddNewWorkGroup.Name = "buttonAddNewWorkGroup";
            this.buttonAddNewWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonAddNewWorkGroup.TabIndex = 6;
            this.buttonAddNewWorkGroup.Text = "Добавить новую рабочую группу";
            this.buttonAddNewWorkGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewWorkGroup.Click += new System.EventHandler(this.buttonAddNewWorkGroup_Click);
            // 
            // dataGridViewWorkGroupsList
            // 
            this.dataGridViewWorkGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkGroupsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitile,
            this.ColumnDescroption});
            this.dataGridViewWorkGroupsList.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewWorkGroupsList.Name = "dataGridViewWorkGroupsList";
            this.dataGridViewWorkGroupsList.Size = new System.Drawing.Size(778, 323);
            this.dataGridViewWorkGroupsList.TabIndex = 5;
            this.dataGridViewWorkGroupsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkGroupsList_CellContentClick);
            // 
            // ColumnTitile
            // 
            this.ColumnTitile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTitile.HeaderText = "Название";
            this.ColumnTitile.Name = "ColumnTitile";
            // 
            // ColumnDescroption
            // 
            this.ColumnDescroption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescroption.HeaderText = "Описание";
            this.ColumnDescroption.Name = "ColumnDescroption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список рабочих групп";
            // 
            // tabPagePersonalInformation
            // 
            this.tabPagePersonalInformation.Controls.Add(this.labelStatus);
            this.tabPagePersonalInformation.Controls.Add(this.labelStar);
            this.tabPagePersonalInformation.Controls.Add(this.comboBoxRole);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxEmail);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPhoneNumber);
            this.tabPagePersonalInformation.Controls.Add(this.buttonRenewPersonalInformation);
            this.tabPagePersonalInformation.Controls.Add(this.label9);
            this.tabPagePersonalInformation.Controls.Add(this.label8);
            this.tabPagePersonalInformation.Controls.Add(this.dateTimePickerDateOfBirth);
            this.tabPagePersonalInformation.Controls.Add(this.label7);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPassword);
            this.tabPagePersonalInformation.Controls.Add(this.label6);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxLogin);
            this.tabPagePersonalInformation.Controls.Add(this.label5);
            this.tabPagePersonalInformation.Controls.Add(this.label4);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPosition);
            this.tabPagePersonalInformation.Controls.Add(this.label3);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxFullName);
            this.tabPagePersonalInformation.Controls.Add(this.label10);
            this.tabPagePersonalInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalInformation.Name = "tabPagePersonalInformation";
            this.tabPagePersonalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInformation.Size = new System.Drawing.Size(792, 424);
            this.tabPagePersonalInformation.TabIndex = 2;
            this.tabPagePersonalInformation.Text = "Личная информация";
            this.tabPagePersonalInformation.UseVisualStyleBackColor = true;
            this.tabPagePersonalInformation.Click += new System.EventHandler(this.tabPagePersonalInformation_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Сотрудник",
            "Руководитель"});
            this.comboBoxRole.Enabled = false;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Сотрудник ",
            "Руководитель"});
            this.comboBoxRole.Location = new System.Drawing.Point(211, 213);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRole.TabIndex = 36;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(400, 275);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 35;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(221, 275);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 34;
            // 
            // buttonRenewPersonalInformation
            // 
            this.buttonRenewPersonalInformation.Location = new System.Drawing.Point(250, 328);
            this.buttonRenewPersonalInformation.Name = "buttonRenewPersonalInformation";
            this.buttonRenewPersonalInformation.Size = new System.Drawing.Size(229, 23);
            this.buttonRenewPersonalInformation.TabIndex = 33;
            this.buttonRenewPersonalInformation.Text = "Обновить личную инфомацию";
            this.buttonRenewPersonalInformation.UseVisualStyleBackColor = true;
            this.buttonRenewPersonalInformation.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Дата рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(371, 210);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Телефон";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(371, 147);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(371, 90);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Роль";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(221, 147);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Должность";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(221, 90);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullName.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ФИО";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(125, 35);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 16);
            this.labelStatus.TabIndex = 59;
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStar.Location = new System.Drawing.Point(91, 32);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(18, 24);
            this.labelStar.TabIndex = 58;
            this.labelStar.Text = "*";
            // 
            // FormManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormManagerMain";
            this.Text = "FormManagerMain";
            this.Load += new System.EventHandler(this.FormManagerMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesList)).EndInit();
            this.tabPageWorkingGroups.ResumeLayout(false);
            this.tabPageWorkingGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkGroupsList)).EndInit();
            this.tabPagePersonalInformation.ResumeLayout(false);
            this.tabPagePersonalInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageWorkingGroups;
        private System.Windows.Forms.TabPage tabPagePersonalInformation;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteSelectedEmployee;
        private System.Windows.Forms.Button buttonInformationAboutSelectedEmployee;
        private System.Windows.Forms.Button buttonDeleteSelectedWorkGroup;
        private System.Windows.Forms.Button buttonGoToSelectedWorkGroup;
        private System.Windows.Forms.Button buttonEditSelectedWorkGroup;
        private System.Windows.Forms.Button buttonAddNewWorkGroup;
        private System.Windows.Forms.DataGridView dataGridViewWorkGroupsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRenewPersonalInformation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescroption;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStar;
    }
}