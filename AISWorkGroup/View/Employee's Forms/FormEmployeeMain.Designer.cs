namespace AISWorkGroup.View.Employee_s_Forms
{
    partial class FormEmployeeMain
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
            this.tabControlEmployeeMain = new System.Windows.Forms.TabControl();
            this.tabPageWorkingGroups = new System.Windows.Forms.TabPage();
            this.buttonGoToSelectedWorkGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeesGroups = new System.Windows.Forms.DataGridView();
            this.tabPagePersonalInformation = new System.Windows.Forms.TabPage();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
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
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonRenewPersonalInformation = new System.Windows.Forms.Button();
            this.tabControlEmployeeMain.SuspendLayout();
            this.tabPageWorkingGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesGroups)).BeginInit();
            this.tabPagePersonalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEmployeeMain
            // 
            this.tabControlEmployeeMain.Controls.Add(this.tabPageWorkingGroups);
            this.tabControlEmployeeMain.Controls.Add(this.tabPagePersonalInformation);
            this.tabControlEmployeeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmployeeMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmployeeMain.Multiline = true;
            this.tabControlEmployeeMain.Name = "tabControlEmployeeMain";
            this.tabControlEmployeeMain.SelectedIndex = 0;
            this.tabControlEmployeeMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlEmployeeMain.TabIndex = 0;
            // 
            // tabPageWorkingGroups
            // 
            this.tabPageWorkingGroups.Controls.Add(this.buttonGoToSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.label1);
            this.tabPageWorkingGroups.Controls.Add(this.dataGridViewEmployeesGroups);
            this.tabPageWorkingGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkingGroups.Name = "tabPageWorkingGroups";
            this.tabPageWorkingGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkingGroups.Size = new System.Drawing.Size(792, 424);
            this.tabPageWorkingGroups.TabIndex = 0;
            this.tabPageWorkingGroups.Text = "Рабочие группы";
            this.tabPageWorkingGroups.UseVisualStyleBackColor = true;
            // 
            // buttonGoToSelectedWorkGroup
            // 
            this.buttonGoToSelectedWorkGroup.Location = new System.Drawing.Point(56, 392);
            this.buttonGoToSelectedWorkGroup.Name = "buttonGoToSelectedWorkGroup";
            this.buttonGoToSelectedWorkGroup.Size = new System.Drawing.Size(661, 23);
            this.buttonGoToSelectedWorkGroup.TabIndex = 6;
            this.buttonGoToSelectedWorkGroup.Text = "Перейти к выбранной рабочей группе";
            this.buttonGoToSelectedWorkGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список рабочих групп, в которых вы состоите";
            // 
            // dataGridViewEmployeesGroups
            // 
            this.dataGridViewEmployeesGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeesGroups.Location = new System.Drawing.Point(26, 29);
            this.dataGridViewEmployeesGroups.Name = "dataGridViewEmployeesGroups";
            this.dataGridViewEmployeesGroups.Size = new System.Drawing.Size(741, 355);
            this.dataGridViewEmployeesGroups.TabIndex = 4;
            // 
            // tabPagePersonalInformation
            // 
            this.tabPagePersonalInformation.Controls.Add(this.buttonRenewPersonalInformation);
            this.tabPagePersonalInformation.Controls.Add(this.comboBoxRole);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxEmail);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPhoneNumber);
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
            this.tabPagePersonalInformation.TabIndex = 1;
            this.tabPagePersonalInformation.Text = "Личная информация";
            this.tabPagePersonalInformation.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(400, 303);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 51;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(221, 303);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Дата рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(371, 238);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Телефон";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(371, 175);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(371, 118);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Роль";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(221, 175);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Должность";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(221, 118);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullName.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "ФИО";
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
            this.comboBoxRole.Location = new System.Drawing.Point(211, 241);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRole.TabIndex = 52;
            // 
            // buttonRenewPersonalInformation
            // 
            this.buttonRenewPersonalInformation.Location = new System.Drawing.Point(250, 354);
            this.buttonRenewPersonalInformation.Name = "buttonRenewPersonalInformation";
            this.buttonRenewPersonalInformation.Size = new System.Drawing.Size(229, 23);
            this.buttonRenewPersonalInformation.TabIndex = 53;
            this.buttonRenewPersonalInformation.Text = "Обновить личную инфомацию";
            this.buttonRenewPersonalInformation.UseVisualStyleBackColor = true;
            this.buttonRenewPersonalInformation.Click += new System.EventHandler(this.buttonRenewPersonalInformation_Click);
            // 
            // FormEmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlEmployeeMain);
            this.Name = "FormEmployeeMain";
            this.Text = "Форма сотрудника";
            this.Load += new System.EventHandler(this.FormEmployeeMain_Load);
            this.tabControlEmployeeMain.ResumeLayout(false);
            this.tabPageWorkingGroups.ResumeLayout(false);
            this.tabPageWorkingGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesGroups)).EndInit();
            this.tabPagePersonalInformation.ResumeLayout(false);
            this.tabPagePersonalInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployeeMain;
        private System.Windows.Forms.TabPage tabPageWorkingGroups;
        private System.Windows.Forms.Button buttonGoToSelectedWorkGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesGroups;
        private System.Windows.Forms.TabPage tabPagePersonalInformation;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
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
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonRenewPersonalInformation;
    }
}