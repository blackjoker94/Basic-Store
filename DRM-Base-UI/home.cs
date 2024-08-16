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
        private DetailedBook detailedBook;
        private home homeform;
        public home()
        {
            InitializeComponent();
            storeBtn_Click(null, EventArgs.Empty);


        }

        private void Detalied(object sender, EventArgs e)
        {
            detailedBook.BringToFront();
            homeform.SendToBack();
            homeform.Hide();
            detailedBook.Show();
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
            // Ensure the panel and button are reset to avoid glitches
            menu_panel.Visible = false;
            logo.Visible = false;

            // Clear the current image
            menuBtn.Image = null;

            if (menu_panel.Width == 62)
            {
                // Expand
                menu_panel.Width = 170;
                logo.Width = 100;
                logo.Height = 100;
                logo.Location = new Point(40, 80);
                menuBtn.Location = new Point(126, 50);
                menu_transition.ShowSync(menu_panel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
                LogoTrans.ShowSync(logo, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizBlind);
                menuBtn.Image = Properties.Resources.leftarrow;
            }
            else
            {
                // Minimize
                menu_panel.Width = 62;
                logo.Width = 50;
                logo.Height = 50;
                logo.Location = new Point(12, 105);
                menuBtn.Location = new Point(24, 48);
                menu_transition2.ShowSync(menu_panel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
                menuBtn.Image = Properties.Resources.rightarrow;
            }
            menu_panel.Visible = true;
            logo.Visible = true;
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
                profileBtn.Location = new Point(837, 41);//50
                profilePanel.Location = new Point(725, 36);//41
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
                CopiedLabel.Visible = false;

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

        public void loadform(object Form)
        {
            if (this.replace_panel.Controls.Count > 0)
            {
                this.replace_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.replace_panel.Controls.Add(f);
            this.replace_panel.Tag = f;
            f.Show();
        }


        private void SetActiveButton(Bunifu.UI.WinForms.BunifuButton.BunifuButton activeButton)
        {
            Color activeBackColor = Color.FromArgb(219, 95, 64);
            Color idleBackColor = Color.FromArgb(32, 34, 37);
            Color onHoverColor = Color.FromArgb(81, 34, 0);
            Color activeTextColor = Color.White;
            Color idleTextColor = Color.White;

            SetButtonStyle(storeBtn, idleBackColor, idleTextColor, onHoverColor);
            SetButtonStyle(libraryBtn, idleBackColor, idleTextColor, onHoverColor);
            SetButtonStyle(viewerBtn, idleBackColor, idleTextColor, onHoverColor);
            SetButtonStyle(downloadsBtn, idleBackColor, idleTextColor, onHoverColor);


            SetButtonStyle(activeButton, activeBackColor, activeTextColor, onHoverColor);
        }

        private void SetButtonStyle(Bunifu.UI.WinForms.BunifuButton.BunifuButton button, Color backColor, Color textColor, Color onhoverColor)
        {

            button.IdleFillColor = backColor;
            button.OnIdleState.FillColor = backColor;
            button.OnIdleState.ForeColor = textColor;
            button.OnPressedState.FillColor = backColor;
            button.OnPressedState.ForeColor = textColor;
            button.onHoverState.FillColor = onhoverColor;
            button.onHoverState.ForeColor = textColor;
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            store storeForm = new store();
            loadform(storeForm);
            SetActiveButton(storeBtn);
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            library libraryForm = new library();
            loadform(libraryForm);
            SetActiveButton(libraryBtn);
        }

        private void viewerBtn_Click(object sender, EventArgs e)
        {
            viewer viewerForm = new viewer();
            loadform(viewerForm);
            SetActiveButton(viewerBtn);
        }

        private void downloadsBtn_Click(object sender, EventArgs e)
        {
            downloads downloadsForm = new downloads();
            loadform(downloadsForm);
            SetActiveButton(downloadsBtn);
        }

        private void copyIDBtn_Click(object sender, EventArgs e)
        {
            string idToCopy = IDLabel.Text;
            Clipboard.SetText(idToCopy);
            CopiedLabel.Visible = true;
        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}