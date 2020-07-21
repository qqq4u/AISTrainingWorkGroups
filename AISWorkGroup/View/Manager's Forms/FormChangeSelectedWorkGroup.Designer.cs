namespace AISWorkGroup.View.Manager_s_Forms
{
    partial class FormChangeSelectedWorkGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridViewAllEmployees = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeesInSelectedGroup = new System.Windows.Forms.DataGridView();
            this.buttonAddToGroup = new System.Windows.Forms.Button();
            this.buttonDeleteFromGroup = new System.Windows.Forms.Button();
            this.buttonChangeWorkGroup = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesInSelectedGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(27, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(27, 130);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(168, 265);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(54, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Описание";
            // 
            // dataGridViewAllEmployees
            // 
            this.dataGridViewAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEmployees.Location = new System.Drawing.Point(327, 39);
            this.dataGridViewAllEmployees.Name = "dataGridViewAllEmployees";
            this.dataGridViewAllEmployees.Size = new System.Drawing.Size(216, 280);
            this.dataGridViewAllEmployees.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Все сотрудники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сотрудники в группе";
            // 
            // dataGridViewEmployeesInSelectedGroup
            // 
            this.dataGridViewEmployeesInSelectedGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeesInSelectedGroup.Location = new System.Drawing.Point(572, 39);
            this.dataGridViewEmployeesInSelectedGroup.Name = "dataGridViewEmployeesInSelectedGroup";
            this.dataGridViewEmployeesInSelectedGroup.Size = new System.Drawing.Size(216, 280);
            this.dataGridViewEmployeesInSelectedGroup.TabIndex = 6;
            // 
            // buttonAddToGroup
            // 
            this.buttonAddToGroup.Location = new System.Drawing.Point(386, 343);
            this.buttonAddToGroup.Name = "buttonAddToGroup";
            this.buttonAddToGroup.Size = new System.Drawing.Size(129, 23);
            this.buttonAddToGroup.TabIndex = 8;
            this.buttonAddToGroup.Text = "Добавить в группу";
            this.buttonAddToGroup.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFromGroup
            // 
            this.buttonDeleteFromGroup.Location = new System.Drawing.Point(620, 343);
            this.buttonDeleteFromGroup.Name = "buttonDeleteFromGroup";
            this.buttonDeleteFromGroup.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteFromGroup.TabIndex = 9;
            this.buttonDeleteFromGroup.Text = "Удалить из группы";
            this.buttonDeleteFromGroup.UseVisualStyleBackColor = true;
            // 
            // buttonChangeWorkGroup
            // 
            this.buttonChangeWorkGroup.Location = new System.Drawing.Point(220, 404);
            this.buttonChangeWorkGroup.Name = "buttonChangeWorkGroup";
            this.buttonChangeWorkGroup.Size = new System.Drawing.Size(497, 23);
            this.buttonChangeWorkGroup.TabIndex = 10;
            this.buttonChangeWorkGroup.Text = "Изменить рабочую группу";
            this.buttonChangeWorkGroup.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(220, 448);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(497, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormChangeSelectedWorkGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChangeWorkGroup);
            this.Controls.Add(this.buttonDeleteFromGroup);
            this.Controls.Add(this.buttonAddToGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewEmployeesInSelectedGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAllEmployees);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeSelectedWorkGroup";
            this.Text = "FormChangeSelectedWorkGroup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesInSelectedGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridViewAllEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesInSelectedGroup;
        private System.Windows.Forms.Button buttonAddToGroup;
        private System.Windows.Forms.Button buttonDeleteFromGroup;
        private System.Windows.Forms.Button buttonChangeWorkGroup;
        private System.Windows.Forms.Button buttonExit;
    }
}