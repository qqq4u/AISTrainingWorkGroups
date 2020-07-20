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
            this.tabPagePersonalInformation = new System.Windows.Forms.TabPage();
            this.buttonGoToSelectedWorkGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeesGroups = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlEmployeeMain.SuspendLayout();
            this.tabPageWorkingGroups.SuspendLayout();
            this.tabPagePersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesGroups)).BeginInit();
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
            // tabPagePersonalInformation
            // 
            this.tabPagePersonalInformation.Controls.Add(this.button1);
            this.tabPagePersonalInformation.Controls.Add(this.maskedTextBox1);
            this.tabPagePersonalInformation.Controls.Add(this.label9);
            this.tabPagePersonalInformation.Controls.Add(this.label8);
            this.tabPagePersonalInformation.Controls.Add(this.dateTimePicker1);
            this.tabPagePersonalInformation.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.tabPagePersonalInformation.Controls.Add(this.label7);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPassword);
            this.tabPagePersonalInformation.Controls.Add(this.label6);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxLogin);
            this.tabPagePersonalInformation.Controls.Add(this.label5);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxRole);
            this.tabPagePersonalInformation.Controls.Add(this.label4);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPosition);
            this.tabPagePersonalInformation.Controls.Add(this.label3);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxFullName);
            this.tabPagePersonalInformation.Controls.Add(this.label2);
            this.tabPagePersonalInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalInformation.Name = "tabPagePersonalInformation";
            this.tabPagePersonalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInformation.Size = new System.Drawing.Size(792, 424);
            this.tabPagePersonalInformation.TabIndex = 1;
            this.tabPagePersonalInformation.Text = "Личная информация";
            this.tabPagePersonalInformation.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФИО";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(41, 57);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(41, 114);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(41, 177);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxRole.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Роль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(191, 57);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(191, 114);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Телефон";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(41, 230);
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Дата рождения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(220, 230);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Обновить личную инфомацию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormEmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlEmployeeMain);
            this.Name = "FormEmployeeMain";
            this.Text = "Форма сотрудника";
            this.tabControlEmployeeMain.ResumeLayout(false);
            this.tabPageWorkingGroups.ResumeLayout(false);
            this.tabPageWorkingGroups.PerformLayout();
            this.tabPagePersonalInformation.ResumeLayout(false);
            this.tabPagePersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployeeMain;
        private System.Windows.Forms.TabPage tabPageWorkingGroups;
        private System.Windows.Forms.Button buttonGoToSelectedWorkGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesGroups;
        private System.Windows.Forms.TabPage tabPagePersonalInformation;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}