namespace AISWorkGroup.View.Employee_s_Forms
{
    partial class FormGroupInfo
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeesInGroup = new System.Windows.Forms.DataGridView();
            this.dataGridViewTasksForGroup = new System.Windows.Forms.DataGridView();
            this.buttonLookSelectedTaskWithReport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesInGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasksForGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(63, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 182);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(226, 177);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сотрудники в группе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Задачи для группы";
            // 
            // dataGridViewEmployeesInGroup
            // 
            this.dataGridViewEmployeesInGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeesInGroup.Location = new System.Drawing.Point(478, 35);
            this.dataGridViewEmployeesInGroup.Name = "dataGridViewEmployeesInGroup";
            this.dataGridViewEmployeesInGroup.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEmployeesInGroup.TabIndex = 6;
            // 
            // dataGridViewTasksForGroup
            // 
            this.dataGridViewTasksForGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasksForGroup.Location = new System.Drawing.Point(478, 226);
            this.dataGridViewTasksForGroup.Name = "dataGridViewTasksForGroup";
            this.dataGridViewTasksForGroup.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTasksForGroup.TabIndex = 7;
            // 
            // buttonLookSelectedTaskWithReport
            // 
            this.buttonLookSelectedTaskWithReport.Location = new System.Drawing.Point(218, 451);
            this.buttonLookSelectedTaskWithReport.Name = "buttonLookSelectedTaskWithReport";
            this.buttonLookSelectedTaskWithReport.Size = new System.Drawing.Size(335, 23);
            this.buttonLookSelectedTaskWithReport.TabIndex = 8;
            this.buttonLookSelectedTaskWithReport.Text = "Посмотреть выбранную задачу вместе с отчётом";
            this.buttonLookSelectedTaskWithReport.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(342, 480);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLookSelectedTaskWithReport);
            this.Controls.Add(this.dataGridViewTasksForGroup);
            this.Controls.Add(this.dataGridViewEmployeesInGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormGroupInfo";
            this.Text = "FormGroupInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesInGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasksForGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesInGroup;
        private System.Windows.Forms.DataGridView dataGridViewTasksForGroup;
        private System.Windows.Forms.Button buttonLookSelectedTaskWithReport;
        private System.Windows.Forms.Button buttonExit;
    }
}