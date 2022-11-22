using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            wrongLable.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSelectUser.SelectedIndex==0) //choose student
            {
                panel1.Visible = false;
                panel2.Visible = true;
                
            }else if(txtSelectUser.SelectedIndex==1)
            {
                panel2.Visible = false;
                panel1.Visible = true;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true) 
            {
                txtPassword.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";

            }else if(checkBox1.Checked== false)
            {
                txtPassword.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="wan"&& txtPassword.Text == "xiaohan")
            {
                wrongLable.Visible = false;
                Teacher te =new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                wrongLable.Visible = true;
            }
        }
    }
}
