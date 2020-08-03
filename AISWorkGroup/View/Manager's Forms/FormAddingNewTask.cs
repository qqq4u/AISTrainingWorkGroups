using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AISWorkGroup.Model;
using MySql.Data.MySqlClient;

namespace AISWorkGroup.View.Manager_s_Forms
{
    public partial class FormAddingNewTask : Form
    {
        public FormAddingNewTask()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE title = '{textBoxName.Text}' AND importance = '{comboBoxImportance.Text}' AND deadline = '{dateTimePickerDeadLine.Value}' AND description = '{richTextBoxDescription.Text}' AND group_id = {GlobalVariables.selectedWorkGroupID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();


            if (textBoxName.Text == string.Empty || richTextBoxDescription.Text == string.Empty || comboBoxImportance.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполнены","Ошибка добавления",MessageBoxButtons.OK,MessageBoxIcon.Error);
                reader.Close();
            }
            else if(reader.HasRows)
            {
                MessageBox.Show("Такая задача для данной группы уже существует","Ошибка добавления",MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
            else
            {
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"INSERT INTO `tasks`(title,importance,deadline,status,description,group_id) VALUES ('{textBoxName.Text}','{comboBoxImportance.Text}','{dateTimePickerDeadLine.Value:yyyy-MM-dd}', 'Создана','{richTextBoxDescription.Text}', {GlobalVariables.selectedWorkGroupID})";
                DBConnector.mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Новая задача для группы успешно добавлена","Добавление",MessageBoxButtons.OK);
                this.Close();
                
            }
        }
    }
}
