using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace loginapps
{
    public partial class Form1 : Form
    {
        int state = 0; 
        string user;
        string pass;
        string user1 = "admin";
        string pass2 = "admin";
        int count = 0;
        string date = DateTime.Today.ToShortDateString();
        private bool closealtf4;
        //private bool tm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;

            label4.Text = "Today's date is :";
            label5.Text = date;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            user = textBox1.Text;
            pass = textBox2.Text;
            if(user == user1 && pass == pass2 && state == 0) {
                count = 0;


        
        Application.Exit();
                 
            }
            //else if (state == 1){
            //    if (user == user1 && pass == pass2)
            //    {
            //        label6.Text = "Input new Username and Password";
            //        count = 0;
            //        user1 = textBox1.Text;
            //        pass2 = textBox2.Text;
            //        state = 0;
            //        label6.Visible = false;
            //        label3.Visible = false; 
            //    }
            //}
            else
            {
                count++;
                if (count == 1)
                {
                    label3.Text = "Wrong password";
                    label3.Visible = true;
                }
                else if(count == 2)
                {
                    label3.Text = "Wrong again,i more wrong and i'll restart your computer for ya";
                    label3.Visible = true;
                }
                else if(count ==3)
                {
                    label3.Text = "Restarting";
                    label3.Visible = true;
                    
                    Process.Start("shutdown", "/s /t 5");
                    
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "Username";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = "Password";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closealtf4)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    closealtf4 = false;
                }
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                closealtf4 = true;
            else if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            //else if (e.Control && e.Alt && e.KeyCode == Keys.Delete) { 
            //    tm = true;
            //}

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    state = 1;
        //    label6.Text = "Input old Username and Password";
        //    label6.Visible = true;
            

        //    }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    state = 0;
            
        //}
    }
}
