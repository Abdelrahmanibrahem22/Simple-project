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
    public partial class registring : Form
    {
        public string item;
        public registring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fees fee = new fees();
            fee.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login ln = new login();
            this.Hide();
            ln.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            item = comboBox2.Text;
            MessageBox.Show(item);
            pmethod pme = new pmethod();
            this.Hide();
            pme.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registring_Load(object sender, EventArgs e)
        {

        }
    }
}
