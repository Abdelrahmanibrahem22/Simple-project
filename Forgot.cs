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
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newpass np = new newpass();
            this.Close();
            np.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sent");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void Forgot_Load(object sender, EventArgs e)
        {

        }
    }
}
