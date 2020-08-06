using AISWorkGroup.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISWorkGroup.View.Employee_s_Forms
{
    public partial class FormAddingReport : Form
    {
        public FormAddingReport()
        {
            InitializeComponent();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            

            if (richTextBoxReport.Text == string.Empty || pictureBox1.Image == null || pictureBox2.Image == null)
            {   
                MessageBox.Show("Нельзя оставлять пустые поля в отчёте!", "Ошибка добавления отчёта",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"INSERT `reports`(report_text,photo_1,photo_2) VALUES('{richTextBoxReport.Text}','{pictureBox1.ImageLocation.Replace(@"\",@"\\")}','{pictureBox2.ImageLocation.Replace(@"\", @"\\")}')";              

                DBConnector.mySqlCommand.ExecuteNonQuery();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `reports` ORDER BY id DESC LIMIT 1";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                int report_id=-1;
                if (reader.Read())
                {  report_id = reader.GetInt32("id"); }
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `tasks` SET report_id ={report_id} WHERE id = {GlobalVariables.selectedTaskID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Отчёт к задаче успешно создан","Создание отчёта",MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void buttonEditPhoto1_Click(object sender, EventArgs e)
        {
           

            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK) 
            {

                pictureBox1.ImageLocation = openFileDialogPhoto.FileName;
            }

        }

        private void buttonEditPhoto2_Click(object sender, EventArgs e)
        {
            
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK) 
            {
                pictureBox2.ImageLocation = openFileDialogPhoto.FileName;
            }
        }
    }
}
