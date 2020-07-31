﻿namespace AISWorkGroup.View.Manager_s_Forms
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddToGroup = new System.Windows.Forms.Button();
            this.buttonDeleteFromGroup = new System.Windows.Forms.Button();
            this.buttonChangeWorkGroup = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridViewAllEmployees = new System.Windows.Forms.DataGridView();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEployeesInSelectedGroup = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEployeesInSelectedGroup)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Все сотрудники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сотрудники в группе";
            // 
            // buttonAddToGroup
            // 
            this.buttonAddToGroup.Location = new System.Drawing.Point(386, 343);
            this.buttonAddToGroup.Name = "buttonAddToGroup";
            this.buttonAddToGroup.Size = new System.Drawing.Size(129, 23);
            this.buttonAddToGroup.TabIndex = 8;
            this.buttonAddToGroup.Text = "Добавить в группу";
            this.buttonAddToGroup.UseVisualStyleBackColor = true;
            this.buttonAddToGroup.Click += new System.EventHandler(this.buttonAddToGroup_Click);
            // 
            // buttonDeleteFromGroup
            // 
            this.buttonDeleteFromGroup.Location = new System.Drawing.Point(620, 343);
            this.buttonDeleteFromGroup.Name = "buttonDeleteFromGroup";
            this.buttonDeleteFromGroup.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteFromGroup.TabIndex = 9;
            this.buttonDeleteFromGroup.Text = "Удалить из группы";
            this.buttonDeleteFromGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteFromGroup.Click += new System.EventHandler(this.buttonDeleteFromGroup_Click);
            // 
            // buttonChangeWorkGroup
            // 
            this.buttonChangeWorkGroup.Location = new System.Drawing.Point(220, 404);
            this.buttonChangeWorkGroup.Name = "buttonChangeWorkGroup";
            this.buttonChangeWorkGroup.Size = new System.Drawing.Size(497, 23);
            this.buttonChangeWorkGroup.TabIndex = 10;
            this.buttonChangeWorkGroup.Text = "Изменить рабочую группу";
            this.buttonChangeWorkGroup.UseVisualStyleBackColor = true;
            this.buttonChangeWorkGroup.Click += new System.EventHandler(this.buttonChangeWorkGroup_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(220, 448);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(497, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridViewAllEmployees
            // 
            this.dataGridViewAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPosition,
            this.ColumnFullName});
            this.dataGridViewAllEmployees.Location = new System.Drawing.Point(329, 39);
            this.dataGridViewAllEmployees.Name = "dataGridViewAllEmployees";
            this.dataGridViewAllEmployees.Size = new System.Drawing.Size(216, 280);
            this.dataGridViewAllEmployees.TabIndex = 17;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPosition.HeaderText = "Должность";
            this.ColumnPosition.Name = "ColumnPosition";
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFullName.HeaderText = "ФИО";
            this.ColumnFullName.Name = "ColumnFullName";
            // 
            // dataGridViewEployeesInSelectedGroup
            // 
            this.dataGridViewEployeesInSelectedGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEployeesInSelectedGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewEployeesInSelectedGroup.Location = new System.Drawing.Point(572, 39);
            this.dataGridViewEployeesInSelectedGroup.Name = "dataGridViewEployeesInSelectedGroup";
            this.dataGridViewEployeesInSelectedGroup.Size = new System.Drawing.Size(216, 280);
            this.dataGridViewEployeesInSelectedGroup.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FormChangeSelectedWorkGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.dataGridViewEployeesInSelectedGroup);
            this.Controls.Add(this.dataGridViewAllEmployees);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChangeWorkGroup);
            this.Controls.Add(this.buttonDeleteFromGroup);
            this.Controls.Add(this.buttonAddToGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeSelectedWorkGroup";
            this.Text = "FormChangeSelectedWorkGroup";
            this.Load += new System.EventHandler(this.FormChangeSelectedWorkGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEployeesInSelectedGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddToGroup;
        private System.Windows.Forms.Button buttonDeleteFromGroup;
        private System.Windows.Forms.Button buttonChangeWorkGroup;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewAllEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridView dataGridViewEployeesInSelectedGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}