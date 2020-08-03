using AISWorkGroup.Model;
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
using AISWorkGroup.View.Manager_s_Forms;

namespace AISWorkGroup.View.Employee_s_Forms
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

            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE group_id = {GlobalVariables.selectedWorkGroupID}";
            reader = DBConnector.mySqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridViewTasksForGroup.Rows.Add(reader.GetString("title"), reader.GetString("importance"), reader.GetDateTime("deadline").ToString("yyyy-MM-dd"), reader.GetString("status"), reader.GetString("description"));
                }
            }
            reader.Close();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLookSelectedTaskWithReport_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            if (dataGridViewTasksForGroup.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали ни одной задачи или выбрали более одной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE title = '{dataGridViewTasksForGroup.SelectedRows[0].Cells[0].Value.ToString()}' AND importance = '{dataGridViewTasksForGroup.SelectedRows[0].Cells[1].Value.ToString()}' AND deadline = '{dataGridViewTasksForGroup.SelectedRows[0].Cells[2].Value.ToString()}' AND status = '{dataGridViewTasksForGroup.SelectedRows[0].Cells[3].Value.ToString()}' AND description = '{dataGridViewTasksForGroup.SelectedRows[0].Cells[4].Value.ToString()}' AND group_id = {GlobalVariables.selectedWorkGroupID}";
                reader = DBConnector.mySqlCommand.ExecuteReader();
                reader.Read();
                GlobalVariables.selectedTaskID = reader.GetInt32("id");
                reader.Close();
                this.Visible = false;
                Form form = new FormTaskWithReport();
                form.ShowDialog();
                dataGridViewTasksForGroup.Rows.Clear();

                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE group_id = {GlobalVariables.selectedWorkGroupID}";
                reader = DBConnector.mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    dataGridViewTasksForGroup.Rows.Add(reader.GetString("title"), reader.GetString("importance"), reader.GetDateTime("deadline").ToString(), reader.GetString("status"), reader.GetString("description"));
                }
                reader.Close();
                this.Visible = true;
            }
        }
    }
}
