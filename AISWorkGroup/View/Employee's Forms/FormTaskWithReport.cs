using AISWorkGroup.Model;
using AISWorkGroup.View.Employee_s_Forms;
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


    public partial class TaskWithReport : Form
    {
        public TaskWithReport()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskWithReport_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxName.Text = reader.GetString("title");
            textBoxDeadLine.Text = reader.GetDateTime("deadline").ToString(format: "yyyy-MM-dd");
            richTextBoxDescription.Text = reader.GetString("description");
            textBoxImportance.Text = reader.GetString("importance");
            comboBoxStatus.Text = reader.GetString("status");


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

            if (comboBoxStatus.Text=="Завершена"||comboBoxStatus.Text == "Одобрено")
            {
                comboBoxStatus.Enabled = false;
                buttonAddReport.Enabled = false;
                buttonChangeReport.Enabled = false;
                buttonRenewStatus.Enabled = false;
            }

        }

        private void buttonAddReport_Click(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE report_id IS NULL AND id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                MessageBox.Show("Отчёт к этой задаче уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reader.Close();
                Form form = new FormAddingReport();

                this.Visible = false;
                form.ShowDialog();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
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

                this.Visible = true;
            }
        }

        private void buttonChangeReport_Click(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE report_id IS NULL AND id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                MessageBox.Show("Отчёт к этой задаче ещё не существует", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reader.Close();
                Form form = new FormEditingReport();

                this.Visible = false;
                form.ShowDialog();

                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
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

                this.Visible = true;

            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRenewStatus_Click(object sender, EventArgs e)
        {

            if (comboBoxStatus.SelectedIndex == 3 || comboBoxStatus.SelectedIndex == 4 || comboBoxStatus.SelectedIndex == 0)
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                MessageBox.Show("Данный статус может ставить только руководитель!", "Ошибка смены статуса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxStatus.Text = reader.GetString("status");
                reader.Close();
            }
            else
                if (comboBoxStatus.SelectedIndex == 2)
            {

                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();

                if (reader.IsDBNull(7))
                {
                    comboBoxStatus.Text = reader.GetString("status");
                    reader.Close();

                    MessageBox.Show("Нельзя завершить задачу без отчёта!", "Ошибка смены статуса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `tasks` SET status = '{comboBoxStatus.Text}' WHERE id = {GlobalVariables.selectedTaskID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успешная смена статуса у задачи", "Смена статуса");

                    comboBoxStatus.Enabled = false;
                    buttonAddReport.Enabled = false;
                    buttonChangeReport.Enabled = false;
                    buttonRenewStatus.Enabled = false;
                }
            }
            else         
            {
                
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `tasks` SET status = '{comboBoxStatus.Text}' WHERE id = {GlobalVariables.selectedTaskID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успешная смена статуса у задачи","Смена статуса");
            }

           
        }
    }
}

