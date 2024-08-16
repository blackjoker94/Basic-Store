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
    public partial class login : Form
    {
        private login loginForm;
        private home home;
        private register register;
        public login()
        {
            InitializeComponent();
            loginForm = this; // This refers to the current instance of the Login form
            home = new home();
            home.Hide();
            register = new register(this);
            register.Hide();
            loginForm.Show(); // Show the login form
            this.Load += new EventHandler(Form1_Load);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginButton.Refresh();
            RegisterButton.Refresh();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_click(object sender, EventArgs e)
        {
            string id = emailTextBox.Text;
            if (IsValidUser(id))
            {
                home.BringToFront();
                loginForm.SendToBack();
                home.Show();
                loginForm.Hide();

            }
            else
            {
                MessageBox.Show("Invalid ID. Please try again.", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidUser(string id)
        {
            if (id == "")
                return true;
            else
                return false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void SignUp(object sender, EventArgs e)
        {
            register.BringToFront();
            loginForm.SendToBack();
            loginForm.Hide();
            register.Show();
        }

        private void alphaBlendTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click_1(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
