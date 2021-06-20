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
    public partial class Form2 : Form
    {
        
        functionsDB fn = new functionsDB();
        String query;
        int index;
            
        private void button2_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM TableList WHERE Taken = 1 ";
            DataSet ds = fn.GetData(query);
            dgv1.DataSource = ds.Tables[0];
        }
        public Form2()
        {
            InitializeComponent();
            
        }
      
        private void btLogOut(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new();
            f1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM TableList WHERE Booked = 1 ";
            DataSet ds = fn.GetData(query);
            dgv1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            query = "SELECT * FROM TableList WHERE Booked = 0 ";
            DataSet ds = fn.GetData(query);
            dgv1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM TableList";
            DataSet ds = fn.GetData(query);
            dgv1.DataSource = ds.Tables[0];
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

            index = dgv1.SelectedRows[0].Index;

            SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=tablesDb;integrated security = True");
            string query = "UPDATE TableList SET Taken = 1 WHERE sID = " + (index + 1) + " UPDATE TableList SET Booked = 0 WHERE sID = " + (index + 1);
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Form2_Load(this, null);

        }
    
        private void butSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu();
            this.Hide();
            sm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM TableList ";
            DataSet ds = fn.GetData(query);
            dgv1.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index = dgv1.SelectedRows[0].Index;

            SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=tablesDb;integrated security = True");
            string query = "UPDATE TableList SET Taken = 0 WHERE sID = " + (index + 1);
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Form2_Load(this, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index = dgv1.SelectedRows[0].Index;

            SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=tablesDb;integrated security = True");
            string query = "UPDATE TableList SET Booked = 1 WHERE sID = " + (index + 1);
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Form2_Load(this, null);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            index = dgv1.SelectedRows[0].Index;

            SqlConnection sqlcon = new SqlConnection(@"data source = (LocalDb)\MSSqllocalDB;database=tablesDb;integrated security = True");
            string query = "UPDATE TableList SET Booked = 0 WHERE sID = " + (index + 1);
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Form2_Load(this, null);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM TableList WHERE Taken = 0 ";
            DataSet ds = fn.GetData(query);
            dgv1.DataSource = ds.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgv1.Columns["sID"].Visible = false;

        }
    }
}
