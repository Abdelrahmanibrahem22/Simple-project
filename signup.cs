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
    public partial class signup : Form
    {

        public signup()
        {
            InitializeComponent();
        }
        public string phonenum ="0";
      
        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
            

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pass.Text == Pass2.Text)
            {
                phonenum = phone_num.Text;
                vcode l = new vcode(this);
                this.Hide();
                l.ShowDialog();
            }
            else
                MessageBox.Show("password is't confirm");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            phonenum = phone_num.Text;
            MessageBox.Show(phonenum.ToString());
        }
    }
}
