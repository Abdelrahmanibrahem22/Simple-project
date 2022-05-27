using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_PROJECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup sup = new signup();
            this.Hide();
            sup.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot fg = new Forgot();
            this.Hide();
            fg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text =="admin")
            {
                registring rg = new registring();
                this.Hide();
                rg.Show();
            }
            else
                MessageBox.Show("ID or password is incorrect");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
