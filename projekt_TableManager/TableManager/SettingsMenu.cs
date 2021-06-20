using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_wip
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUser auf = new addUser();
            this.Hide();
            auf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeUser ru = new removeUser();
            this.Hide();
            ru.Show();
        }
    }
}
