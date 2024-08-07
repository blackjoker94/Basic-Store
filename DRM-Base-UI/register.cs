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
        private login login;
        public register(login loginForm)
        {
            InitializeComponent();
            login = loginForm;
            grade_drobbox.BorderRadius = 35;
            certi_dropbox.BorderRadius = 35;
            grade_drobbox.Items.AddRange(new string[] { "None", "grade1", "grade2", "grade3" });
            grade_drobbox.SelectedIndex = 0; // Select "None" by default
            certi_dropbox.Enabled = false;
            grade_drobbox.SelectedIndexChanged += Grade_drobbox_SelectedIndexChanged;

        }
        // Replace with your actual data structure
        Dictionary<string, List<string>> gradeOptions = new Dictionary<string, List<string>>
        {
    { "grade1", new List<string> { "grade1_1", "grade1_2" } },
    { "grade2", new List<string> { "grade2_1", "grade2_2" } },
    { "grade3", new List<string> { "grade3_1", "grade3_2" } }
        };




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
            login.BringToFront();
            this.Hide();
            login.Show();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void Grade_drobbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGrade = grade_drobbox.SelectedItem.ToString();

            if (selectedGrade == "None")
            {
                certi_dropbox.Enabled = false;
                certi_dropbox.Items.Clear();
            }
            else if (gradeOptions.ContainsKey(selectedGrade))
            {
                certi_dropbox.Enabled = true;
                certi_dropbox.Items.Clear();
                certi_dropbox.Items.AddRange(gradeOptions[selectedGrade].ToArray());
                certi_dropbox.Text = "Select an option";
            }
        }

    }
}