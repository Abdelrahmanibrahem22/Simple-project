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
    public partial class credit : Form
    {
        public credit()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pmethod pm = new pmethod();
            this.Hide();
            pm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rmethod rm = new rmethod();
            this.Hide();
            rm.ShowDialog();
        }

        private void credit_Load(object sender, EventArgs e)
        {

        }
    }
}
