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
            if(menu_panel.Width==60)
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
                menu_panel.Width = 60;//79
                logo.Width = 50;
                logo.Height = 50;
                logo.Location = new Point(12, 130);//25,153
                menuBtn.Location = new Point(19, 76);
                menu_transition2.ShowSync(menu_panel);

            }
        }
    }
}
