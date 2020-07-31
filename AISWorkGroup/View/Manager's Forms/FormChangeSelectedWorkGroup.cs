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
    public partial class FormChangeSelectedWorkGroup : Form
    {
        public FormChangeSelectedWorkGroup()
        {
            InitializeComponent();
        }

        private void FormChangeSelectedWorkGroup_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE role = 0";


            dataGridViewAllEmployees.Rows.Clear();
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewAllEmployees.Rows.Add(reader.GetString("position"), reader.GetString("full_name"));
            }

            reader.Close();





            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` JOIN `users_groups_connection` ON `users_groups_connection`.id_user = `users`.id WHERE `users_groups_connection`.id_group = {GlobalVariables.selectedWorkGroupID}";
            
            dataGridViewEployeesInSelectedGroup.Rows.Clear();
            reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewEployeesInSelectedGroup.Rows.Add(reader.GetString("position"), reader.GetString("full_name"));
            }

            reader.Close();
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` WHERE id = {GlobalVariables.selectedWorkGroupID}";
            reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxName.Text = reader.GetString("name");
            richTextBoxDescription.Text = reader.GetString("description");

                reader.Close();
        }

        private void buttonAddToGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника или выбрали более одного сотрудника", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridViewEployeesInSelectedGroup.Rows.Add(dataGridViewAllEmployees.SelectedRows[0].Cells[0].Value.ToString(), dataGridViewAllEmployees.SelectedRows[0].Cells[1].Value.ToString());


            }
        }

        private void buttonChangeWorkGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewEployeesInSelectedGroup.Rows.Count > 0)
            {
                DBConnector.mySqlCommand.CommandText = $@"UPDATE `workgroups` SET name = '{textBoxName.Text}', description = '{richTextBoxDescription.Text}' WHERE id = {GlobalVariables.selectedWorkGroupID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();

                DBConnector.mySqlCommand.CommandText = $@"DELETE FROM `users_groups_connection` WHERE id_group = {GlobalVariables.selectedWorkGroupID}";
                DBConnector.mySqlCommand.ExecuteNonQuery();

                MySqlDataReader reader;

                int id_user = -1;

                for (int i = 0; i < dataGridViewEployeesInSelectedGroup.Rows.Count - 1; i++)
                {
                    DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE full_name = '{dataGridViewEployeesInSelectedGroup.Rows[i].Cells[1].Value}' AND position = '{dataGridViewEployeesInSelectedGroup.Rows[i].Cells[0].Value}' AND role = 0";

                    reader = DBConnector.mySqlCommand.ExecuteReader();
                    if (reader.Read())
                    { id_user = reader.GetInt32("id"); }
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"INSERT `users_groups_connection`(id_user, id_group) VALUES({id_user},{GlobalVariables.selectedWorkGroupID})";
                    DBConnector.mySqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Успешное изменение группы");
                this.Close();
            }
            else
            {
                MessageBox.Show("Нельзя сделать группу пустой!", "Ошибка изменения",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
    
        }

        private void buttonDeleteFromGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewEployeesInSelectedGroup.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника или выбрали более одного сотрудника", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                dataGridViewEployeesInSelectedGroup.Rows.Remove(dataGridViewEployeesInSelectedGroup.SelectedRows[0]);

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
