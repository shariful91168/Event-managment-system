using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventManagementSystem
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {

                if (textBox2.Text != "")
                {
                    int num1 = int.Parse(textBox2.Text);
                    int num2 = 500;
                   // t1.Visible = true;
                    int result = num1 * num2;
                    textBox3.Text = "" + result;

                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox2.Text != "")
                {
                    int num1 = int.Parse(textBox2.Text);
                    int num2 = 640;
                   // t2.Visible = true;
                    int result = num1 * num2;
                    textBox3.Text = "" + result;
                  
                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (textBox2.Text != "")
                {
                    int num1 = int.Parse(textBox2.Text);
                    int num2 = 320;
                   // t3.Visible = true;
                    int result = num1 * num2;
                    textBox3.Text = "" + result;
                  


                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (textBox2.Text != "")
                {
                    int num1 = int.Parse(textBox2.Text);
                    int num2 = 300;
                   // t2.Visible = true;
                    int result = num1 * num2;
                    textBox3.Text = "" + result;


                }

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                if (textBox2.Text != "")
                {
                    int num1 = int.Parse(textBox2.Text);
                    int num2 = 200;

                    int result = num1 * num2;
                    textBox3.Text = "" + result;


                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    if (textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox2.Text);
                        int num2 = 200;

                        int result = num1 * num2;
                        textBox3.Text = "" + result;

                    }

                }

            }



           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Your Reservation is Confirmed", "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (ds == DialogResult.OK)
            {
                Package pg = new Package();
                pg.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult ds = MessageBox.Show("Thank you for Coming", "Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            home pg = new home();
            pg.Show();
            this.Hide();
        }
    } }

