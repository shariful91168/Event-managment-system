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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn f2 = new LogIn();
            f2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup f3 = new signup();
            f3.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
