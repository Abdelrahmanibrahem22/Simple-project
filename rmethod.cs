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
    public partial class rmethod : Form
    {
        public rmethod()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //devloc dev = new devloc();
            //this.Hide();
            //dev.Show();
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pmethod pm = new pmethod();
            this.Hide();
            pm.Show();
        }

        private void con_ptn_Click(object sender, EventArgs e)
        {
            Receipt re = new Receipt();
            this.Hide();
            re.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt re = new Receipt();
            this.Hide();
            re.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
