using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekt_wip
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu();
            this.Hide();
            sm.Show();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            if (newUsertxt.Text != "" && newPasstxt.Text != "")
            {

                SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=logindb;integrated security = True");
                string query = "INSERT INTO dbo.usersdb (username, password) VALUES ('" + newUsertxt.Text.Trim() + "', '" + newPasstxt.Text.Trim() + "')";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DialogResult result = MessageBox.Show("Succesfully added " + newUsertxt.Text + " to users", "OK");
                if (result == DialogResult.OK)
                {
                    SettingsMenu sm = new SettingsMenu();
                    this.Hide();
                    sm.Show();
                }

            }
            else
                MessageBox.Show("Username or password not given, try again", "OK");

        }
    }
}
