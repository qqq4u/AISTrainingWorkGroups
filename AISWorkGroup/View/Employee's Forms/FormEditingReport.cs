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
    public partial class FormEditingReport : Form
    {
        public FormEditingReport()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditingReport_Load(object sender, EventArgs e)
        {

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            int report_id = reader.GetInt32("report_id");
            reader.Close();
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `reports` WHERE id = {report_id}";
            reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            richTextBoxReport.Text = reader.GetString("report_text");
            pictureBox1.ImageLocation = reader.GetString("photo_1");
            pictureBox2.ImageLocation = reader.GetString("photo_2");
            reader.Close();
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

        private void buttonEditReport_Click(object sender, EventArgs e)
        {
            if (richTextBoxReport.Text == string.Empty || pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Нельзя оставлять пустые поля в отчёте!", "Ошибка изменения отчёта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";

                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                int report_id = reader.GetInt32("report_id");
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `reports` WHERE id = {report_id}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();

                if (richTextBoxReport.Text == reader.GetString("report_text") && pictureBox1.ImageLocation == reader.GetString("photo_1") && pictureBox2.ImageLocation == reader.GetString("photo_2"))
                {
                    reader.Close();
                    MessageBox.Show("Вы не изменили отчёт!","Ошибка обновления отчёта",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader.Close();


                DBConnector.mySqlCommand.CommandText = $@"UPDATE `reports` SET report_text ='{richTextBoxReport.Text}', photo_1 = '{pictureBox1.ImageLocation.Replace(@"\", @"\\")}', photo_2 = '{pictureBox2.ImageLocation.Replace(@"\", @"\\")}' WHERE id = {report_id}";

                DBConnector.mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Отчёт к задаче успешно изменён!", "Изменение отчёта", MessageBoxButtons.OK);
                this.Close();
                }
            }
        }
    }
}
