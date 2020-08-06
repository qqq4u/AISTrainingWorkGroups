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
using AISWorkGroup.View;
using AISWorkGroup.View.Manager_s_Forms;
using AISWorkGroup.View.Employee_s_Forms;

namespace AISWorkGroup.View.General_Forms
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlConnection.Open();
            DBConnector.mySqlCommand.Connection = DBConnector.mySqlConnection;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            GlobalVariables.authorizedUserId = -1;


            if (textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty || comboBoxRole.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполненны!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE `login` = '{textBoxLogin.Text}' AND `password` = '{ textBoxPassword.Text}' AND `role` = {comboBoxRole.SelectedIndex}";
               MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (comboBoxRole.SelectedIndex == 1)
                    {
                        reader.Read();
                        GlobalVariables.authorizedUserId = reader.GetInt32("id");
                        reader.Close();
                        DBConnector.mySqlCommand.CommandText = $@"UPDATE `users` SET status = 1 WHERE id = {GlobalVariables.authorizedUserId}";
                        DBConnector.mySqlCommand.ExecuteNonQuery();
                        Form managerForm = new FormManagerMain();
                        this.Visible = false;
                        managerForm.ShowDialog();
                        DBConnector.mySqlCommand.CommandText = $@"UPDATE `users` SET status = 0 WHERE id = {GlobalVariables.authorizedUserId}";
                        DBConnector.mySqlCommand.ExecuteNonQuery();

                        this.Visible = true;
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        comboBoxRole.Text = string.Empty;
                    }
                    else
                    {
                        reader.Read();
                        GlobalVariables.authorizedUserId = reader.GetInt32("id");
                        reader.Close();
                        DBConnector.mySqlCommand.CommandText = $@"UPDATE `users` SET status = 1 WHERE id = {GlobalVariables.authorizedUserId}";
                        DBConnector.mySqlCommand.ExecuteNonQuery();
                        Form employeeForm = new FormEmployeeMain();
                            this.Visible = false;
                        employeeForm.ShowDialog();
                        DBConnector.mySqlCommand.CommandText = $@"UPDATE `users` SET status = 0 WHERE id = {GlobalVariables.authorizedUserId}";
                        DBConnector.mySqlCommand.ExecuteNonQuery();
                        this.Visible = true;
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        comboBoxRole.Text = string.Empty;

                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show( "Такого пользователя не существует!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                    comboBoxRole.Text = string.Empty;
                }
            }


        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Form regestrationForm = new FormRegistration();
            this.Visible = false;
            regestrationForm.ShowDialog();
            this.Visible = true;
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            comboBoxRole.Text = string.Empty;
        }
    }
}
