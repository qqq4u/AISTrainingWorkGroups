namespace AISWorkGroup.View.Manager_s_Forms
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLookSelectedTaskWithReport = new System.Windows.Forms.Button();
            this.dataGridViewTasksForGroup = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInportance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddNewTAskForWorkGroup = new System.Windows.Forms.Button();
            this.buttonEditSelectedTaskForWorkGroup = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedTaskForWorkGroup = new System.Windows.Forms.Button();
            this.dataGridViewEployeesInSelectedGroup = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasksForGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEployeesInSelectedGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(377, 612);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLookSelectedTaskWithReport
            // 
            this.buttonLookSelectedTaskWithReport.Location = new System.Drawing.Point(235, 463);
            this.buttonLookSelectedTaskWithReport.Name = "buttonLookSelectedTaskWithReport";
            this.buttonLookSelectedTaskWithReport.Size = new System.Drawing.Size(335, 23);
            this.buttonLookSelectedTaskWithReport.TabIndex = 18;
            this.buttonLookSelectedTaskWithReport.Text = "Посмотреть выбранную задачу вместе с отчётом";
            this.buttonLookSelectedTaskWithReport.UseVisualStyleBackColor = true;
            this.buttonLookSelectedTaskWithReport.Click += new System.EventHandler(this.buttonLookSelectedTaskWithReport_Click);
            // 
            // dataGridViewTasksForGroup
            // 
            this.dataGridViewTasksForGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasksForGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnInportance,
            this.ColumnDeadline,
            this.ColumnStatus,
            this.ColumnDescription});
            this.dataGridViewTasksForGroup.Location = new System.Drawing.Point(398, 291);
            this.dataGridViewTasksForGroup.Name = "dataGridViewTasksForGroup";
            this.dataGridViewTasksForGroup.Size = new System.Drawing.Size(547, 150);
            this.dataGridViewTasksForGroup.TabIndex = 17;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnInportance
            // 
            this.ColumnInportance.HeaderText = "Важность";
            this.ColumnInportance.Name = "ColumnInportance";
            // 
            // ColumnDeadline
            // 
            this.ColumnDeadline.HeaderText = "Дедлайн";
            this.ColumnDeadline.Name = "ColumnDeadline";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Описание";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Задачи для группы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Сотрудники в группе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(47, 151);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(226, 177);
            this.richTextBoxDescription.TabIndex = 11;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(98, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // buttonAddNewTAskForWorkGroup
            // 
            this.buttonAddNewTAskForWorkGroup.Location = new System.Drawing.Point(235, 492);
            this.buttonAddNewTAskForWorkGroup.Name = "buttonAddNewTAskForWorkGroup";
            this.buttonAddNewTAskForWorkGroup.Size = new System.Drawing.Size(335, 23);
            this.buttonAddNewTAskForWorkGroup.TabIndex = 20;
            this.buttonAddNewTAskForWorkGroup.Text = "Добавить новую задачу для рабочей группы";
            this.buttonAddNewTAskForWorkGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewTAskForWorkGroup.Click += new System.EventHandler(this.buttonAddNewTAskForWorkGroup_Click);
            // 
            // buttonEditSelectedTaskForWorkGroup
            // 
            this.buttonEditSelectedTaskForWorkGroup.Location = new System.Drawing.Point(235, 521);
            this.buttonEditSelectedTaskForWorkGroup.Name = "buttonEditSelectedTaskForWorkGroup";
            this.buttonEditSelectedTaskForWorkGroup.Size = new System.Drawing.Size(335, 23);
            this.buttonEditSelectedTaskForWorkGroup.TabIndex = 21;
            this.buttonEditSelectedTaskForWorkGroup.Text = "Изменить выбранную задачу для рабочей группы";
            this.buttonEditSelectedTaskForWorkGroup.UseVisualStyleBackColor = true;
            this.buttonEditSelectedTaskForWorkGroup.Click += new System.EventHandler(this.buttonEditSelectedTaskForWorkGroup_Click);
            // 
            // buttonDeleteSelectedTaskForWorkGroup
            // 
            this.buttonDeleteSelectedTaskForWorkGroup.Location = new System.Drawing.Point(235, 550);
            this.buttonDeleteSelectedTaskForWorkGroup.Name = "buttonDeleteSelectedTaskForWorkGroup";
            this.buttonDeleteSelectedTaskForWorkGroup.Size = new System.Drawing.Size(335, 23);
            this.buttonDeleteSelectedTaskForWorkGroup.TabIndex = 22;
            this.buttonDeleteSelectedTaskForWorkGroup.Text = "Удалить выбранную задачу для рабочей группы";
            this.buttonDeleteSelectedTaskForWorkGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedTaskForWorkGroup.Click += new System.EventHandler(this.buttonDeleteSelectedTaskForWorkGroup_Click);
            // 
            // dataGridViewEployeesInSelectedGroup
            // 
            this.dataGridViewEployeesInSelectedGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEployeesInSelectedGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewEployeesInSelectedGroup.Location = new System.Drawing.Point(498, 17);
            this.dataGridViewEployeesInSelectedGroup.Name = "dataGridViewEployeesInSelectedGroup";
            this.dataGridViewEployeesInSelectedGroup.Size = new System.Drawing.Size(347, 225);
            this.dataGridViewEployeesInSelectedGroup.TabIndex = 23;
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
            // FormGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 675);
            this.Controls.Add(this.dataGridViewEployeesInSelectedGroup);
            this.Controls.Add(this.buttonDeleteSelectedTaskForWorkGroup);
            this.Controls.Add(this.buttonEditSelectedTaskForWorkGroup);
            this.Controls.Add(this.buttonAddNewTAskForWorkGroup);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLookSelectedTaskWithReport);
            this.Controls.Add(this.dataGridViewTasksForGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormGroupInfo";
            this.Text = "FormGroupInfo";
            this.Load += new System.EventHandler(this.FormGroupInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasksForGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEployeesInSelectedGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLookSelectedTaskWithReport;
        private System.Windows.Forms.DataGridView dataGridViewTasksForGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddNewTAskForWorkGroup;
        private System.Windows.Forms.Button buttonEditSelectedTaskForWorkGroup;
        private System.Windows.Forms.Button buttonDeleteSelectedTaskForWorkGroup;
        private System.Windows.Forms.DataGridView dataGridViewEployeesInSelectedGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInportance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
    }
}