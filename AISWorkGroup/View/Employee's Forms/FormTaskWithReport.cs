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

namespace AISWorkGroup.View.General_Forms
{
    public partial class TaskWithReport : Form
    {
        public TaskWithReport()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskWithReport_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `tasks` WHERE id = {GlobalVariables.selectedTaskID}";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            reader.Read();
            textBoxName.Text = reader.GetString("title");
            textBoxDeadLine.Text = reader.GetDateTime("deadline").ToString(format: "yyyy-MM-dd");
            richTextBoxDescription.Text = reader.GetString("description");
            textBoxImportance.Text = reader.GetString("importance");
            comboBoxStatus.Text = reader.GetString("status");
            reader.Close();
        }
    }
}
