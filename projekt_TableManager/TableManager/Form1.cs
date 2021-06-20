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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal class PicturePanel : Panel
        {
            public PicturePanel()
            {
                this.DoubleBuffered = true;
                this.AutoScroll = true;
                this.BackgroundImageLayout = ImageLayout.Center;
            }
            public override Image BackgroundImage
            {
                get { return base.BackgroundImage; }
                set
                {
                    base.BackgroundImage = value;
                    if (value != null) this.AutoScrollMinSize = value.Size;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=logindb;integrated security = True");
            //sqlcon.ConnectionString = @"data source = (LocalDb)\MSSqllocalDB;database=tablesDb;integrated security = True";
            string query = "SELECT * FROM usersdb WHERE username = '" + usernametxt.Text.Trim() + "' AND password = '" + passwordtxt.Text.Trim()+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
                
            }
            else
            {
                MessageBox.Show("Bledny login lub haslo");

            }
            
        }

       
    }
}
