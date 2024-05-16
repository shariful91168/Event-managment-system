using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decoration Cost = 2,00,000BDT!" + Environment.NewLine + "Food Cost per-person = 500BDT", "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decoration Cost = 50000BDT!"+ Environment.NewLine +"Food Cost Per-person = 500BDT" , "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decoration Cost = 1,50,000BDT!" + Environment.NewLine + "Food Cost per-person = 500BDT", "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decoration Cost = 50,000BDT!" + Environment.NewLine + "Food Cost per-person = 200BDT", "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decoration Cost = 50,000BDT!" + Environment.NewLine + "Food Cost per-person = 20BDT", "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart f4 = new Cart();
            f4.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn f2 = new LogIn();
            f2.Show();
            Visible = false;
        }
    }
}
