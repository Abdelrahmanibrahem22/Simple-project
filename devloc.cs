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
    public partial class devloc : Form
    {
        public devloc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registring re = new registring();
            this.Hide();
            re.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt re = new Receipt();
            this.Hide();
            re.ShowDialog();
        }

        private void devloc_Load(object sender, EventArgs e)
        {

        }
    }
}
