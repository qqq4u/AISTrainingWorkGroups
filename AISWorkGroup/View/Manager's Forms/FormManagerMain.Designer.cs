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
            this.tabPageWorkingGroups = new System.Windows.Forms.TabPage();
            this.tabPagePersonalInformation = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeesList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEditSelectedWorkGroup = new System.Windows.Forms.Button();
            this.buttonCreateNewWorkGroup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteSelectedWorkGroup = new System.Windows.Forms.Button();
            this.buttonGoToSelectedWorkGroup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            this.tabPageWorkingGroups.SuspendLayout();
            this.tabPagePersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.button2);
            this.tabPageEmployees.Controls.Add(this.button1);
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
            // tabPageWorkingGroups
            // 
            this.tabPageWorkingGroups.Controls.Add(this.buttonDeleteSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.buttonGoToSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.buttonEditSelectedWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.buttonCreateNewWorkGroup);
            this.tabPageWorkingGroups.Controls.Add(this.dataGridView1);
            this.tabPageWorkingGroups.Controls.Add(this.label2);
            this.tabPageWorkingGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkingGroups.Name = "tabPageWorkingGroups";
            this.tabPageWorkingGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkingGroups.Size = new System.Drawing.Size(792, 424);
            this.tabPageWorkingGroups.TabIndex = 1;
            this.tabPageWorkingGroups.Text = "Рабочие группы";
            this.tabPageWorkingGroups.UseVisualStyleBackColor = true;
            // 
            // tabPagePersonalInformation
            // 
            this.tabPagePersonalInformation.Controls.Add(this.button3);
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
            this.tabPagePersonalInformation.Controls.Add(this.label10);
            this.tabPagePersonalInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalInformation.Name = "tabPagePersonalInformation";
            this.tabPagePersonalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInformation.Size = new System.Drawing.Size(792, 424);
            this.tabPagePersonalInformation.TabIndex = 2;
            this.tabPagePersonalInformation.Text = "Личная информация";
            this.tabPagePersonalInformation.UseVisualStyleBackColor = true;
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
            // dataGridViewEmployeesList
            // 
            this.dataGridViewEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeesList.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewEmployeesList.Name = "dataGridViewEmployeesList";
            this.dataGridViewEmployeesList.Size = new System.Drawing.Size(778, 323);
            this.dataGridViewEmployeesList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(661, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подробная информация о выбранном сотруднике";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(661, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить выбранного сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonEditSelectedWorkGroup
            // 
            this.buttonEditSelectedWorkGroup.Location = new System.Drawing.Point(65, 391);
            this.buttonEditSelectedWorkGroup.Name = "buttonEditSelectedWorkGroup";
            this.buttonEditSelectedWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonEditSelectedWorkGroup.TabIndex = 7;
            this.buttonEditSelectedWorkGroup.Text = "Изменить выбранную рабочую группу";
            this.buttonEditSelectedWorkGroup.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNewWorkGroup
            // 
            this.buttonCreateNewWorkGroup.Location = new System.Drawing.Point(65, 362);
            this.buttonCreateNewWorkGroup.Name = "buttonCreateNewWorkGroup";
            this.buttonCreateNewWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonCreateNewWorkGroup.TabIndex = 6;
            this.buttonCreateNewWorkGroup.Text = "Добавить новую рабочую группу";
            this.buttonCreateNewWorkGroup.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 323);
            this.dataGridView1.TabIndex = 5;
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
            // buttonDeleteSelectedWorkGroup
            // 
            this.buttonDeleteSelectedWorkGroup.Location = new System.Drawing.Point(426, 391);
            this.buttonDeleteSelectedWorkGroup.Name = "buttonDeleteSelectedWorkGroup";
            this.buttonDeleteSelectedWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonDeleteSelectedWorkGroup.TabIndex = 9;
            this.buttonDeleteSelectedWorkGroup.Text = "Удалить выбранного сотрудника";
            this.buttonDeleteSelectedWorkGroup.UseVisualStyleBackColor = true;
            // 
            // buttonGoToSelectedWorkGroup
            // 
            this.buttonGoToSelectedWorkGroup.Location = new System.Drawing.Point(426, 362);
            this.buttonGoToSelectedWorkGroup.Name = "buttonGoToSelectedWorkGroup";
            this.buttonGoToSelectedWorkGroup.Size = new System.Drawing.Size(329, 23);
            this.buttonGoToSelectedWorkGroup.TabIndex = 8;
            this.buttonGoToSelectedWorkGroup.Text = "Подробная информация о выбранном сотруднике";
            this.buttonGoToSelectedWorkGroup.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Обновить личную инфомацию";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(400, 263);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 32;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(221, 263);
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 28;
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
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(221, 210);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxRole.TabIndex = 22;
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
            // FormManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormManagerMain";
            this.Text = "FormManagerMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            this.tabPageWorkingGroups.ResumeLayout(false);
            this.tabPageWorkingGroups.PerformLayout();
            this.tabPagePersonalInformation.ResumeLayout(false);
            this.tabPagePersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageWorkingGroups;
        private System.Windows.Forms.TabPage tabPagePersonalInformation;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeleteSelectedWorkGroup;
        private System.Windows.Forms.Button buttonGoToSelectedWorkGroup;
        private System.Windows.Forms.Button buttonEditSelectedWorkGroup;
        private System.Windows.Forms.Button buttonCreateNewWorkGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.Label label10;
    }
}