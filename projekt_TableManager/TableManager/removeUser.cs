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
    public partial class removeUser : Form
    {
        

        public removeUser()
        {
            InitializeComponent();
            cbFill();
        }

        void cbFill()
        {
            SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=logindb;integrated security = True");
            string query = "SELECT username FROM usersdb";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader myReader;
            try
            {
                sqlcon.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader["username"].ToString();
                    cbUsers.Items.Add(name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu();
            this.Hide();
            sm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbUsers.SelectedIndex >= 0)
            {
                string selectedcb = cbUsers.Text;
                SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=logindb;integrated security = True");
                string query = "DELETE FROM usersdb WHERE username = '" + selectedcb + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DialogResult result = MessageBox.Show("Succesfully removed " + selectedcb + " from users", "OK");
                if (result == DialogResult.OK)
                {
                    SettingsMenu sm = new SettingsMenu();
                    this.Hide();
                    sm.Show();
                }
            }
            else
                MessageBox.Show("No user was selected", "OK");
        }
    }
}
