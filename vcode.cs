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
    public partial class vcode : Form
    {
        signup su;
        public vcode(signup su)
        {
            InitializeComponent();
            this.su = su;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vcode_Load(object sender, EventArgs e)
        {

            pn_output.Text = su.phonenum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            su.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Again");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login li = new login();
            this.Hide();
            li.ShowDialog();
        }
    }
}
