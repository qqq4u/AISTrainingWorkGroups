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
    public partial class FormChangeSelectedTask : Form
    {
        public FormChangeSelectedTask()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangeSelectedTask_Load(object sender, EventArgs e)
        {

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxName.Text = reader.GetString("title");
            dateTimePickerDeadLine.Value = reader.GetDateTime("deadline");
            richTextBoxDescription.Text = reader.GetString("description");
            comboBoxImportance.Text = reader.GetString("importance");
            reader.Close();


        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE title = '{textBoxName.Text}' AND importance = '{comboBoxImportance.Text}' AND deadline = '{dateTimePickerDeadLine.Value.ToString()}' AND description = '{richTextBoxDescription.Text}' AND group_id = {GlobalVariables.selectedWorkGroupID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();


            if (textBoxName.Text == string.Empty || richTextBoxDescription.Text == string.Empty || comboBoxImportance.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
            else if (reader.HasRows)
            {
                MessageBox.Show("Такая задача для данной группы уже существует", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
            else
            {
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `tasks` SET title = '{textBoxName.Text}',importance ='{comboBoxImportance.Text}', deadline = '{dateTimePickerDeadLine.Value:yyyy-MM-dd}', description = '{richTextBoxDescription.Text}' WHERE id = {GlobalVariables.selectedTaskID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Новая задача для группы успешно изменена", "Изменение", MessageBoxButtons.OK);
                this.Close();


            }
        }
    }
}
