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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void menu_click(object sender, EventArgs e)
        {
            if(menu_panel.Width==62)
            {
                //expand
                //menu_panel.Visible = false;
                menu_panel.Width = 170;//225
                menu_transition.ShowSync(menu_panel);
                logo.Width = 100;
                logo.Height = 100;
                logo.Location = new Point(40, 80);
                menuBtn.Location = new Point(126, 50);
            }
            else
            {
                //minize
                //menu_panel.Visible = false;
                menu_panel.Width = 62;//79
                logo.Width = 50;
                logo.Height = 50;
                logo.Location = new Point(12, 130);
                menuBtn.Location = new Point(19, 76);
                menu_transition2.ShowSync(menu_panel);

            }
        }

        private void profileMenu(object sender, EventArgs e)
        {
            BringToFront();
            if (profilePanel.Visible == false)
            {
                //expand
                profilePanel.Visible = true;
                profileTransition.ShowSync(profilePanel);
                profilePanel.Height = 544;
                profileBtn.Location = new Point(842, 50);
                profilePanel.Location = new Point(730, 41);
                profileBtn.BackColor = Color.FromArgb(32, 34, 37);
            }
            else
            {
                //minize
                profilePanel.Visible = false;
                profileBtn.Location = new Point(934, 41);
                profileBtn.BackColor = Color.FromArgb(49, 52, 58);
                profilePanel.Height = 487;
                profileTransition2.HideSync(profilePanel);

            }
        }

        private void userInfo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
