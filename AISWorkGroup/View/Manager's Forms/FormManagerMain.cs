using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AISWorkGroup.Model;

namespace AISWorkGroup.View.Manager_s_Forms
{
    public partial class FormManagerMain : Form
    {
        public FormManagerMain()
        {
            InitializeComponent();
        }

        private void tabPagePersonalInformation_Click(object sender, EventArgs e)
        {

        }

        private void FormManagerMain_Load(object sender, EventArgs e)
        {

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE id = {GlobalVariables.authorizedUserId}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxFullName.Text = reader.GetString("full_name");
            textBoxLogin.Text = reader.GetString("login");
            textBoxPassword.Text = reader.GetString("password");
            textBoxPosition.Text = reader.GetString("position");
            comboBoxRole.SelectedIndex = reader.GetInt32("role");
            textBoxPhoneNumber.Text = reader.GetString("phone_number");
            textBoxEmail.Text = reader.GetString("email");
            dateTimePickerDateOfBirth.Value = reader.GetDateTime("date_of_birth");
            reader.Close();





            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE role = 0";

            dataGridViewEmployeesList.Rows.Clear();

            reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewEmployeesList.Rows.Add(reader.GetString("position"), reader.GetString("full_name"), reader.GetDateTime("date_of_birth").ToString("dd.MM.yyyy"), reader.GetString("phone_number"), reader.GetString("email"));
            }

            reader.Close();


            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups`";

            dataGridViewWorkGroupsList.Rows.Clear();

            reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewWorkGroupsList.Rows.Add(reader.GetString("name"), reader.GetString("description"));
            }

            reader.Close();



        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if ((textBoxFullName.Text == string.Empty || textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty || textBoxPosition.Text == string.Empty || comboBoxRole.Text == string.Empty || textBoxPhoneNumber.Text == string.Empty || textBoxEmail.Text == string.Empty))
            {
                MessageBox.Show("Нельзя оставлять пустых полей!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE full_name = '{ textBoxFullName.Text}' AND login = '{textBoxLogin.Text}'  AND password = '{textBoxPassword.Text}' AND position = '{textBoxPosition.Text}' AND role = {comboBoxRole.SelectedIndex} AND phone_number = '{textBoxPhoneNumber.Text}' AND email = '{textBoxEmail.Text}' AND date_of_birth = '{dateTimePickerDateOfBirth.Value:yyyy-MM-dd}'";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Такой пользователь уже существует или вы не изменили свои данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"UPDATE `users` SET full_name = '{ textBoxFullName.Text}',login = '{textBoxLogin.Text}',password = '{textBoxPassword.Text}', position = '{textBoxPosition.Text}', role = {comboBoxRole.SelectedIndex}, phone_number = '{textBoxPhoneNumber.Text}', email = '{textBoxEmail.Text}', date_of_birth = '{dateTimePickerDateOfBirth.Value:yyyy-MM-dd}' WHERE id = {GlobalVariables.authorizedUserId}";
                    DBConnector.mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Обновление личной информации выполнено", "Успешно!", MessageBoxButtons.OK);


                }

            }
        }

        private void buttonAddNewWorkGroup_Click(object sender, EventArgs e)
        {
            Form form = new FormAddingNewWorkgroup();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups`";

            dataGridViewWorkGroupsList.Rows.Clear();

            var reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewWorkGroupsList.Rows.Add(reader.GetString("name"), reader.GetString("description"));
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployeesList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника или выбрали более одного сотрудника", "Ошибка просмотра", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalVariables.position = dataGridViewEmployeesList.SelectedRows[0].Cells[0].Value.ToString();
                GlobalVariables.fullName = dataGridViewEmployeesList.SelectedRows[0].Cells[1].Value.ToString();
                GlobalVariables.phoneNumber = dataGridViewEmployeesList.SelectedRows[0].Cells[3].Value.ToString();
                GlobalVariables.email = dataGridViewEmployeesList.SelectedRows[0].Cells[4].Value.ToString();
                this.Visible = false;
                FormSelectedEmployeeInfo form = new FormSelectedEmployeeInfo();
                form.ShowDialog();
                this.Visible = true;

            }
        }

        private void buttonDeleteSelectedEmployee_Click(object sender, EventArgs e)
        {
            int user_id;
            if (dataGridViewEmployeesList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одного сотрудника или выбрали более одного сотрудника", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalVariables.position = dataGridViewEmployeesList.SelectedRows[0].Cells[0].Value.ToString();
                GlobalVariables.fullName = dataGridViewEmployeesList.SelectedRows[0].Cells[1].Value.ToString();
                GlobalVariables.phoneNumber = dataGridViewEmployeesList.SelectedRows[0].Cells[3].Value.ToString();
                GlobalVariables.email = dataGridViewEmployeesList.SelectedRows[0].Cells[4].Value.ToString();



                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE position = '{GlobalVariables.position}' AND full_name = '{GlobalVariables.fullName}' AND phone_number = '{GlobalVariables.phoneNumber}' AND email = '{GlobalVariables.email}'";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                user_id = reader.GetInt32("id");
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users_groups_connection` WHERE id_user = {user_id}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Данный работник состоит в группе, вы не можете удалить его", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"DELETE FROM `users` WHERE id = {user_id}";

                    DBConnector.mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Пользаватель удалён!", "Удаление пользователя");

                    DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE role = 0";

                    dataGridViewEmployeesList.Rows.Clear();

                    reader = DBConnector.mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridViewEmployeesList.Rows.Add(reader.GetString("position"), reader.GetString("full_name"), reader.GetDateTime("date_of_birth").ToString("dd.MM.yyyy"), reader.GetString("phone_number"), reader.GetString("email"));
                    }

                    reader.Close();
                }

            }
        }

        private void dataGridViewWorkGroupsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditSelectedWorkGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkGroupsList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одной группы или выбрали более одной", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` WHERE name = '{dataGridViewWorkGroupsList.SelectedRows[0].Cells[0].Value.ToString()}' AND description = '{dataGridViewWorkGroupsList.SelectedRows[0].Cells[1].Value.ToString()}' ";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                GlobalVariables.selectedWorkGroupID = reader.GetInt32("id");
                reader.Close();
                this.Visible = false;
                FormChangeSelectedWorkGroup form = new FormChangeSelectedWorkGroup();
                form.ShowDialog();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups`";

                dataGridViewWorkGroupsList.Rows.Clear();

                 reader = DBConnector.mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    dataGridViewWorkGroupsList.Rows.Add(reader.GetString("name"), reader.GetString("description"));
                }

                reader.Close();
                this.Visible = true;
            }
        }

        private void buttonDeleteSelectedWorkGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkGroupsList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одной группы или выбрали более одной", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` WHERE name = '{dataGridViewWorkGroupsList.SelectedRows[0].Cells[0].Value.ToString()}' AND description = '{dataGridViewWorkGroupsList.SelectedRows[0].Cells[1].Value.ToString()}' ";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                GlobalVariables.selectedWorkGroupID = reader.GetInt32("id");
                reader.Close();

                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE group_id = {GlobalVariables.selectedWorkGroupID}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Невозможно удалить выбранную группу, у неё есть задания","Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"DELETE FROM `workgroups` WHERE id = {GlobalVariables.selectedWorkGroupID}";
                    DBConnector.mySqlCommand.ExecuteNonQuery();
                    DBConnector.mySqlCommand.CommandText = $@"DELETE FROM `users_groups_connection` WHERE id_group = {GlobalVariables.selectedWorkGroupID}";
                    DBConnector.mySqlCommand.ExecuteNonQuery();


                    DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups`";

                    dataGridViewWorkGroupsList.Rows.Clear();

                    reader = DBConnector.mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridViewWorkGroupsList.Rows.Add(reader.GetString("name"), reader.GetString("description"));
                    }

                    reader.Close();


                    MessageBox.Show("Группа была успешно удалена", "Удалено");


                }
            }
        }

        private void buttonGoToSelectedWorkGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkGroupsList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одной группы или выбрали более одной", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` WHERE name = '{dataGridViewWorkGroupsList.SelectedRows[0].Cells[0].Value.ToString()}' AND description = '{dataGridViewWorkGroupsList.SelectedRows[0].Cells[1].Value.ToString()}' ";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                GlobalVariables.selectedWorkGroupID = reader.GetInt32("id");
                reader.Close();
                this.Visible = false;
                Form form = new FormGroupInfo();
                form.ShowDialog();
                this.Visible = true;
            }
        }
    
    }
}
