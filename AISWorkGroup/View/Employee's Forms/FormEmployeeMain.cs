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
        
    }
}
