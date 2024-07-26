using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRM_Base_UI
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void close_reg(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_reg(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_to_login_btn(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Hide();
        }
    }
}
