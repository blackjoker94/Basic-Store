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
    public partial class ProductCard : Bunifu.UI.WinForms.BunifuUserControl
    {
        private string title;
        private string price;
        private string ImgURL;
        private List<string> tags;

        private int hoverOffset = 5;
        private Color originalBorderColor;
        private Color hoverBorderColor = Color.DarkGray;

        private int BookInfoOriginalWidth;
        private int BookInfoOriginalHeight;
        private int BookInfoHoverOffset = 10;




        public ProductCard(string Title, string Price, string ImgURL, List<string> tags)
        {
            InitializeComponent();
            this.title = Title;
            this.price = Price;
            this.ImgURL = ImgURL;
            this.tags = tags;

            originalBorderColor = this.BorderColor;

            BookInfoOriginalWidth = BookInfo.Width;
            BookInfoOriginalHeight = BookInfo.Height;

            this.MouseEnter += new EventHandler(ProductCard_MouseEnter);
            this.MouseLeave += new EventHandler(ProductCard_MouseLeave);

            

            // Attach the Click event to the whole user control
            this.Click += new EventHandler(OpenDetalied);

            // Attach the Click event to all child controls
            AttachClickEventToAllControls(this);
        }

        // Recursively attach the Click event handler to all child controls
        private void AttachClickEventToAllControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                control.Click += new EventHandler(OpenDetalied);

                // If the control has children, recursively attach the event to them too
                if (control.Controls.Count > 0)
                {
                    AttachClickEventToAllControls(control);
                }
            }
        }

        private void ProductCard_MouseEnter(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width + hoverOffset, this.Height + hoverOffset);
            this.BorderColor = hoverBorderColor;
            BookInfo.Width += BookInfoHoverOffset;
            BookInfo.Height += BookInfoHoverOffset;
        }

        private void ProductCard_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width - hoverOffset, this.Height - hoverOffset);
            this.BorderColor = originalBorderColor;
            BookInfo.Width = BookInfoOriginalWidth;
            BookInfo.Height = BookInfoOriginalHeight;
        }

        private void OpenDetalied(object sender, EventArgs e)
        {
            DetailedBook detailedBook = new DetailedBook();
            detailedBook.Show();

        }
    }
}
