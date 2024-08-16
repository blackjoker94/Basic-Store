using System;
using System.Collections.Generic;
using System.Drawing;
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

        private bool isHovered = false;  // Flag to track hover state

        private DetailedBook detailedBook;


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

            // Attach events to the main ProductCard control
            this.MouseEnter += ProductCard_MouseEnter;
            this.MouseLeave += ProductCard_MouseLeave;

            // Register Click event for the whole ProductCard
            this.Click += OpenDetailed;

            // Attach hover effect to all child controls without resetting the hover state
            AttachHoverEffectToAllControls(this);

            detailedBook = new DetailedBook();
        }

        // Recursively attach hover effect to all child controls
        private void AttachHoverEffectToAllControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // Forward hover events from child controls to the parent ProductCard
                control.MouseEnter += (s, e) => ProductCard_MouseEnter(this, e);
                control.MouseLeave += (s, e) => ProductCard_MouseLeave(this, e);

                // Forward click events from child controls to the parent ProductCard
                control.Click += (s, e) => this.OnClick(e);  // Forward the click event

                // Recursively attach the effect to child controls
                if (control.Controls.Count > 0)
                {
                    AttachHoverEffectToAllControls(control);
                }
            }
        }

        private void ProductCard_MouseEnter(object sender, EventArgs e)
        {
            if (!isHovered)
            {
                isHovered = true;  // Set flag when mouse enters the entire ProductCard
                ApplyHoverEffect();
            }
        }

        private void ProductCard_MouseLeave(object sender, EventArgs e)
        {
            // Check if the mouse has left the entire ProductCard, not just a child control
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                isHovered = false;  // Reset flag when mouse leaves the entire ProductCard
                RemoveHoverEffect();
            }
        }

        private void ApplyHoverEffect()
        {
            this.Size = new Size(this.Width + hoverOffset, this.Height + hoverOffset);
            this.BorderColor = hoverBorderColor;
            BookInfo.Width += BookInfoHoverOffset;
            BookInfo.Height += BookInfoHoverOffset;
        }

        private void RemoveHoverEffect()
        {
            this.Size = new Size(this.Width - hoverOffset, this.Height - hoverOffset);
            this.BorderColor = originalBorderColor;
            BookInfo.Width = BookInfoOriginalWidth;
            BookInfo.Height = BookInfoOriginalHeight;
        }

        // Override OnClick to ensure click events are detected properly
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            // Call the detailed view or any other logic you want on click
            OpenDetailed(this, e);
        }

        // Event handler to open the detailed view
        private void OpenDetailed(object sender, EventArgs e)
        {
            if (detailedBook == null || detailedBook.IsDisposed)
            {
                detailedBook = new DetailedBook();
            }
            detailedBook.Show();
        }
    }
}
