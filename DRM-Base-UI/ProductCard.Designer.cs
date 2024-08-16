
namespace DRM_Base_UI
{
    partial class ProductCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.BookInfo = new Bunifu.UI.WinForms.BunifuPanel();
            this.CertificateTag = new Bunifu.UI.WinForms.BunifuLabel();
            this.TeacherTag = new Bunifu.UI.WinForms.BunifuLabel();
            this.GradeTag = new Bunifu.UI.WinForms.BunifuLabel();
            this.EGP = new Bunifu.UI.WinForms.BunifuLabel();
            this.PriceLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.BookPic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BookInfo
            // 
            this.BookInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(95)))), ((int)(((byte)(64)))));
            this.BookInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookInfo.BackgroundImage")));
            this.BookInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(95)))), ((int)(((byte)(64)))));
            this.BookInfo.BorderRadius = 20;
            this.BookInfo.BorderThickness = 1;
            this.BookInfo.Controls.Add(this.CertificateTag);
            this.BookInfo.Controls.Add(this.TeacherTag);
            this.BookInfo.Controls.Add(this.GradeTag);
            this.BookInfo.Controls.Add(this.EGP);
            this.BookInfo.Controls.Add(this.PriceLabel);
            this.BookInfo.Controls.Add(this.TitleLabel);
            this.BookInfo.Location = new System.Drawing.Point(0, 181);
            this.BookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.BookInfo.Name = "BookInfo";
            this.BookInfo.ShowBorders = true;
            this.BookInfo.Size = new System.Drawing.Size(236, 123);
            this.BookInfo.TabIndex = 0;
            // 
            // CertificateTag
            // 
            this.CertificateTag.AllowParentOverrides = false;
            this.CertificateTag.AutoEllipsis = false;
            this.CertificateTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.CertificateTag.CursorType = null;
            this.CertificateTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.CertificateTag.ForeColor = System.Drawing.Color.White;
            this.CertificateTag.Location = new System.Drawing.Point(152, 93);
            this.CertificateTag.Margin = new System.Windows.Forms.Padding(2);
            this.CertificateTag.Name = "CertificateTag";
            this.CertificateTag.Padding = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.CertificateTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CertificateTag.Size = new System.Drawing.Size(79, 25);
            this.CertificateTag.TabIndex = 5;
            this.CertificateTag.Text = "#certificate";
            this.CertificateTag.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CertificateTag.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TeacherTag
            // 
            this.TeacherTag.AllowParentOverrides = false;
            this.TeacherTag.AutoEllipsis = false;
            this.TeacherTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.TeacherTag.CursorType = null;
            this.TeacherTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.TeacherTag.ForeColor = System.Drawing.Color.White;
            this.TeacherTag.Location = new System.Drawing.Point(81, 93);
            this.TeacherTag.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherTag.Name = "TeacherTag";
            this.TeacherTag.Padding = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.TeacherTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TeacherTag.Size = new System.Drawing.Size(62, 25);
            this.TeacherTag.TabIndex = 4;
            this.TeacherTag.Text = "#teacher";
            this.TeacherTag.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TeacherTag.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // GradeTag
            // 
            this.GradeTag.AllowParentOverrides = false;
            this.GradeTag.AutoEllipsis = false;
            this.GradeTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.GradeTag.CursorType = null;
            this.GradeTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.GradeTag.ForeColor = System.Drawing.Color.White;
            this.GradeTag.Location = new System.Drawing.Point(17, 93);
            this.GradeTag.Margin = new System.Windows.Forms.Padding(2);
            this.GradeTag.Name = "GradeTag";
            this.GradeTag.Padding = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.GradeTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GradeTag.Size = new System.Drawing.Size(51, 25);
            this.GradeTag.TabIndex = 3;
            this.GradeTag.Text = "#grade";
            this.GradeTag.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.GradeTag.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // EGP
            // 
            this.EGP.AllowParentOverrides = false;
            this.EGP.AutoEllipsis = false;
            this.EGP.CursorType = null;
            this.EGP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.EGP.ForeColor = System.Drawing.Color.White;
            this.EGP.Location = new System.Drawing.Point(54, 63);
            this.EGP.Margin = new System.Windows.Forms.Padding(2);
            this.EGP.Name = "EGP";
            this.EGP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EGP.Size = new System.Drawing.Size(26, 19);
            this.EGP.TabIndex = 2;
            this.EGP.Text = "EGP";
            this.EGP.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.EGP.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AllowParentOverrides = false;
            this.PriceLabel.AutoEllipsis = false;
            this.PriceLabel.CursorType = null;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(8, 63);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceLabel.Size = new System.Drawing.Size(44, 19);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "900.00";
            this.PriceLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PriceLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowParentOverrides = false;
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.AutoSize = false;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(9, 12);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(218, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Cambridge A.2 Biology (9700) P.P Paper: 5 From 19-24 All Variants.";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BookPic
            // 
            this.BookPic.AllowFocused = false;
            this.BookPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookPic.AutoSizeHeight = true;
            this.BookPic.BorderRadius = 0;
            this.BookPic.Image = ((System.Drawing.Image)(resources.GetObject("BookPic.Image")));
            this.BookPic.IsCircle = true;
            this.BookPic.Location = new System.Drawing.Point(43, 13);
            this.BookPic.Margin = new System.Windows.Forms.Padding(2);
            this.BookPic.Name = "BookPic";
            this.BookPic.Size = new System.Drawing.Size(144, 144);
            this.BookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPic.TabIndex = 1;
            this.BookPic.TabStop = false;
            this.BookPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.GradeTag;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.TeacherTag;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.CertificateTag;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BorderRadius = 20;
            this.Controls.Add(this.BookPic);
            this.Controls.Add(this.BookInfo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(236, 303);
            this.BookInfo.ResumeLayout(false);
            this.BookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel BookInfo;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox BookPic;
        private Bunifu.UI.WinForms.BunifuLabel PriceLabel;
        private Bunifu.UI.WinForms.BunifuLabel EGP;
        private Bunifu.UI.WinForms.BunifuLabel GradeTag;
        private Bunifu.UI.WinForms.BunifuLabel CertificateTag;
        private Bunifu.UI.WinForms.BunifuLabel TeacherTag;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}
