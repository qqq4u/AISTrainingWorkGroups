using AISWorkGroup.Model;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class FormEmployeeMain : Form
    {
        public FormEmployeeMain()
        {
            InitializeComponent();
        }

        private void FormEmployeeMain_Load(object sender, EventArgs e)
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

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` JOIN `users_groups_connection` ON `users_groups_connection`.id_group = `workgroups`.id WHERE `users_groups_connection`.id_user = {GlobalVariables.authorizedUserId}";
            reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewWorkGroupsList.Rows.Add(reader.GetString("name"), reader.GetString("description"));
            }
            reader.Close();

        }

        private void buttonRenewPersonalInformation_Click(object sender, EventArgs e)
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

        private void buttonGoToSelectedWorkGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkGroupsList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одной группы или выбрали более одной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
