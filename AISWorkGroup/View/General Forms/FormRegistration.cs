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
using AISWorkGroup.View;
using MySql.Data.MySqlClient;

namespace AISWorkGroup.View.General_Forms
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == string.Empty || textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty || textBoxPosition.Text == string.Empty || comboBoxRole.Text == string.Empty || textBoxPhoneNumber.Text == string.Empty || textBoxEmail.Text == string.Empty) // Придумать как запихнуть проверку дейттайма
            {
                MessageBox.Show("Не все поля заполненны!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE `login` = '{textBoxLogin.Text}' AND `password` = '{ textBoxPassword.Text}' AND `role` = {comboBoxRole.SelectedIndex} AND `full_name` = '{textBoxFullName.Text}' AND `position` = '{textBoxPosition.Text}' AND `email` = '{textBoxEmail.Text}' AND `date_of_birth`";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Такой пользователь уже существует!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

                }
                else
                {
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"INSERT `workgroups`.`users`(login, password, full_name, role, position, email, date_of_birth) VALUES ('{textBoxLogin.Text}','{textBoxPassword.Text}','{textBoxFullName.Text}', {comboBoxRole.SelectedIndex}, '{textBoxPosition.Text}', '{textBoxEmail.Text}', '{dateTimePickerBirthDate.Value:yyyy-MM-dd}')";
                    DBConnector.mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Успешная регистрация нового пользователя!", "Выполнено", MessageBoxButtons.OK);
                    // сделать олчистку полей

                }
             
            }
        }
    }
}
