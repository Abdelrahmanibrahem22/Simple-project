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
    public partial class pmethod : Form
    {
        public pmethod()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rmethod em = new rmethod();
            this.Hide();
            em.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirm_btn.Enabled = true;
            credit cre = new credit();
            this.Hide();
            cre.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registring re = new registring();
            this.Hide();
            re.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void pmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
