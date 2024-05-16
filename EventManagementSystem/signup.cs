using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F5UT3VQ\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO LOGIN VALUES ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')", con);
            command.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Registration Succesful!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LogIn login = new LogIn();
            login.Show();
            notifyIcon1.BalloonTipText = "Now you can Log In";
            notifyIcon1.BalloonTipTitle = "Hurrah!";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(500);
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home f1 = new home();
            f1.Show();
            Visible = false;
        }
    }
}
