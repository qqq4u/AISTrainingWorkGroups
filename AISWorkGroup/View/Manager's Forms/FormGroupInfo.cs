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
    public partial class FormGroupInfo : Form
    {
        public FormGroupInfo()
        {
            InitializeComponent();
        }

        private void FormGroupInfo_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `workgroups` WHERE id = {GlobalVariables.selectedWorkGroupID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxName.Text = reader.GetString("name");
            richTextBoxDescription.Text = reader.GetString("description");
            reader.Close();


            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` JOIN `users_groups_connection` ON `users_groups_connection`.id_user = `users`.id WHERE `users_groups_connection`.id_group = {GlobalVariables.selectedWorkGroupID}";

            dataGridViewEployeesInSelectedGroup.Rows.Clear();
            reader = DBConnector.mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewEployeesInSelectedGroup.Rows.Add(reader.GetString("position"), reader.GetString("full_name"));
            }

            reader.Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
