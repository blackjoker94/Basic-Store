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
    
    public partial class DetailedBook : Form
    {
        private List<string> Books;
        public DetailedBook()
        {
            InitializeComponent();
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_to_Home_btn(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Discount(bool isDis)
        {
            if(isDis)
            {
                PriceLabel.Font = new Font(PriceLabel.Font, FontStyle.Strikeout);
                EGP.Font = new Font(EGP.Font, FontStyle.Strikeout);
                PriceLabel.ForeColor = Color.Gray;
                EGP.ForeColor = Color.Gray;
                DiscountedPrice.Visible = true;
                DiscountedEGP.Visible = true;
            }
            else
            {
                DiscountedPrice.Visible = false;
                DiscountedEGP.Visible = false;
            }
        }


    }
}