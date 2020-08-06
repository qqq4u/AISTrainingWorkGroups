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

namespace AISWorkGroup.View.Manager_s_Forms
{
    public partial class FormTaskWithReportManager : Form
    {
        public FormTaskWithReportManager()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTaskWithReport_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxName.Text = reader.GetString("title");
            textBoxDeadLine.Text = reader.GetDateTime("deadline").ToString(format: "yyyy-MM-dd");
            richTextBoxDescription.Text = reader.GetString("description");
            textBoxImportance.Text = reader.GetString("importance");
            textBoxStatus.Text = reader.GetString("status");


            if (!reader.IsDBNull(7))
            {
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `reports` JOIN `tasks` ON `reports`.id = `tasks`.report_id WHERE `tasks`.id = {GlobalVariables.selectedTaskID}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                richTextBoxReport.Text = reader.GetString("report_text");
                pictureBox1.ImageLocation = reader.GetString("photo_1");
                pictureBox2.ImageLocation = reader.GetString("photo_2");
                reader.Close();
            }
            else
            {
                reader.Close();
            }
            if (textBoxStatus.Text == "Одобрено" || textBoxStatus.Text == "Отклонено")
            {
                buttonAddReport.Enabled = false;
                buttonDiscardReport.Enabled = false;
            }

        }

        private void buttonAddReport_Click(object sender, EventArgs e)
        {
            if (textBoxStatus.Text != "Завершена")
            {
                MessageBox.Show("Нельзя принять незавершённую работу!","Ошибка изменения статуса", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                textBoxStatus.Text = "Одобрено";
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `tasks` SET status = '{textBoxStatus.Text}' WHERE id = {GlobalVariables.selectedTaskID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Задача успешно принята","Обновление статуса",MessageBoxButtons.OK);
                buttonAddReport.Enabled = false;
                buttonDiscardReport.Enabled = false;
            }
        }

        private void buttonDiscardReport_Click(object sender, EventArgs e)
        {
            if (textBoxStatus.Text != "Завершена")
            {
                MessageBox.Show("Нельзя принять незавершённую работу!", "Ошибка изменения статуса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxStatus.Text = "Отклонено";
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `tasks` SET status = '{textBoxStatus.Text}' WHERE id = {GlobalVariables.selectedTaskID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Задача успешно не принята", "Обновление статуса", MessageBoxButtons.OK);
                buttonAddReport.Enabled = false;
                buttonDiscardReport.Enabled = false;
            }
        }
    }
}
