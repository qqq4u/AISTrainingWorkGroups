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
    public partial class FormSelectedEmployeeInfo : Form
    {
        public FormSelectedEmployeeInfo()
        {
            InitializeComponent();
        }

        private void FormSelectedEmployeeInfo_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE position = '{GlobalVariables.position}' AND full_name = '{GlobalVariables.fullName}' AND phone_number = '{GlobalVariables.phoneNumber}' AND email = '{GlobalVariables.email}'";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxFullName.Text = reader.GetString("full_name");
            textBoxLogin.Text = reader.GetString("login");
            textBoxPassword.Text = reader.GetString("password");
            textBoxPosition.Text = reader.GetString("position");
            comboBoxRole.SelectedIndex = reader.GetInt32("role");
            textBoxPhoneNumber.Text = reader.GetString("phone_number");
            textBoxEmail.Text = reader.GetString("email");
            dateTimePickerBirthDate.Value = reader.GetDateTime("date_of_birth");
            if (reader.GetInt32("status") == 1)
            {
                labelStatus.Text = "На рабочем месте";
                labelStar.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Не на рабочем месте";
                labelStar.ForeColor = Color.Red;
            }
            reader.Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
