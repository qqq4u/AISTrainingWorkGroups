namespace AISWorkGroup.View.Employee_s_Forms
{
    partial class FormEditingReport
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
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.buttonEditPhoto1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEditPhoto2 = new System.Windows.Forms.Button();
            this.buttonEditReport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчёт";
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.Location = new System.Drawing.Point(12, 78);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.Size = new System.Drawing.Size(647, 96);
            this.richTextBoxReport.TabIndex = 1;
            this.richTextBoxReport.Text = "";
            // 
            // buttonEditPhoto1
            // 
            this.buttonEditPhoto1.Location = new System.Drawing.Point(158, 363);
            this.buttonEditPhoto1.Name = "buttonEditPhoto1";
            this.buttonEditPhoto1.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPhoto1.TabIndex = 4;
            this.buttonEditPhoto1.Text = "Изменить";
            this.buttonEditPhoto1.UseVisualStyleBackColor = true;
            this.buttonEditPhoto1.Click += new System.EventHandler(this.buttonEditPhoto1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фото 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фото 2";
            // 
            // buttonEditPhoto2
            // 
            this.buttonEditPhoto2.Location = new System.Drawing.Point(431, 363);
            this.buttonEditPhoto2.Name = "buttonEditPhoto2";
            this.buttonEditPhoto2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditPhoto2.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPhoto2.TabIndex = 7;
            this.buttonEditPhoto2.Text = "Изменить";
            this.buttonEditPhoto2.UseVisualStyleBackColor = true;
            this.buttonEditPhoto2.Click += new System.EventHandler(this.buttonEditPhoto2_Click);
            // 
            // buttonEditReport
            // 
            this.buttonEditReport.Location = new System.Drawing.Point(193, 421);
            this.buttonEditReport.Name = "buttonEditReport";
            this.buttonEditReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditReport.Size = new System.Drawing.Size(386, 23);
            this.buttonEditReport.TabIndex = 8;
            this.buttonEditReport.Text = "Изменить отчёт";
            this.buttonEditReport.UseVisualStyleBackColor = true;
            this.buttonEditReport.Click += new System.EventHandler(this.buttonEditReport_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(213, 450);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(345, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialogPhoto";
            this.openFileDialogPhoto.Filter = " Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif" +
    "; *.png";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(383, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEditReport);
            this.Controls.Add(this.buttonEditPhoto2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEditPhoto1);
            this.Controls.Add(this.richTextBoxReport);
            this.Controls.Add(this.label1);
            this.Name = "FormEditingReport";
            this.Text = "FormEditingReport";
            this.Load += new System.EventHandler(this.FormEditingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxReport;
        private System.Windows.Forms.Button buttonEditPhoto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEditPhoto2;
        private System.Windows.Forms.Button buttonEditReport;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}