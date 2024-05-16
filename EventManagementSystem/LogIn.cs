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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F5UT3VQ\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;");
        private void button2_Click(object sender, EventArgs e)
        {
            Package f5 = new Package();
            f5.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home f1 = new home();
            f1.Show();
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //username = textBox1.Text;
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                string query = "SELECT * FROM LOGIN WHERE Username = '" + textBox1.Text + "'AND Password = '" + textBox2.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    notifyIcon1.BalloonTipText = "Update your Profile";
                    notifyIcon1.BalloonTipTitle = "Welcome to C# Project";
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.ShowBalloonTip(500);
                    DialogResult ds = MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ds == DialogResult.OK)
                    {
                        Package pg = new Package();
                        pg.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }
    }
}
