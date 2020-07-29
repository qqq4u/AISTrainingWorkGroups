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
    public partial class FormAddingNewWorkgroup : Form
    {
        public FormAddingNewWorkgroup()
        {
            InitializeComponent();
        }

        private void buttonCreateWorkGroup_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text == string.Empty || richTextBoxDescription.Text == string.Empty || dataGridViewEmployeesInWorkGrouop.Rows.Count == 0)
            {

                MessageBox.Show("Не все поля заполнены!", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"INSERT `workgroups`(name, description) VALUES('{textBoxName.Text}', '{richTextBoxDescription.Text}')";

                DBConnector.mySqlCommand.ExecuteNonQuery();

                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` ORDER BY id DESC LIMIT 1";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                int id_group = -1 ;
                int id_user = -1;
                if (reader.Read())
                { id_group = reader.GetInt32("id"); }
                
                reader.Close();
                for (int i = 0; i < dataGridViewEmployeesInWorkGrouop.Rows.Count-1; i++)
                {
                    DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE full_name = '{dataGridViewEmployeesInWorkGrouop.Rows[i].Cells[1].Value}' AND position = '{dataGridViewEmployeesInWorkGrouop.Rows[i].Cells[0].Value}' AND role = 0";

                    reader = DBConnector.mySqlCommand.ExecuteReader();
                    if (reader.Read())
                    {  id_user = reader.GetInt32("id"); }
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"INSERT `users_groups_connection`(id_user, id_group) VALUES({id_user},{id_group})";
                    DBConnector.mySqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Успешное добавление");
                this.Close();
            }
        }

        private void FormAddingNewWorkgroup_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE role = 0";

     
            dataGridViewAllEmployees.Rows.Clear();
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewAllEmployees.Rows.Add(reader.GetString("position"), reader.GetString("full_name"));
            }

            reader.Close();
        }

        private void buttonAddToGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника или выбрали более одного сотрудника","Ошибка добавления",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                dataGridViewEmployeesInWorkGrouop.Rows.Add(dataGridViewAllEmployees.SelectedRows[0].Cells[0].Value.ToString(), dataGridViewAllEmployees.SelectedRows[0].Cells[1].Value.ToString()); // ПОСЛАНИЕ ЧИТАЮЩИМ! я знаю, вы тоже в ахуе с того, как я это делаю. Если вы это читаете, то наверняка вы решили разобраться в коде. Вас ждёт ещё много таких крутых моих идей(ёбнуться просто), да и вся структура работы с данными максимально странная, косяк. Приятного изучения!
       

            }
        }

        private void buttonDeleteFromGroup_Click(object sender, EventArgs e)
        {

            if (dataGridViewEmployeesInWorkGrouop.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника или выбрали более одного сотрудника", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                dataGridViewEmployeesInWorkGrouop.Rows.Remove(dataGridViewEmployeesInWorkGrouop.SelectedRows[0]); 

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
