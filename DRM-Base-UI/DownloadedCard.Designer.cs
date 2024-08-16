
namespace DRM_Base_UI
{
    partial class DownloadedCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadedCard));
            this.BookPic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DownloadBar = new Bunifu.UI.WinForms.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BookPic
            // 
            this.BookPic.AllowFocused = false;
            this.BookPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookPic.AutoSizeHeight = true;
            this.BookPic.BorderRadius = 0;
            this.BookPic.Image = ((System.Drawing.Image)(resources.GetObject("BookPic.Image")));
            this.BookPic.IsCircle = true;
            this.BookPic.Location = new System.Drawing.Point(5, 17);
            this.BookPic.Name = "BookPic";
            this.BookPic.Size = new System.Drawing.Size(94, 94);
            this.BookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPic.TabIndex = 2;
            this.BookPic.TabStop = false;
            this.BookPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
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
            this.TitleLabel.Location = new System.Drawing.Point(113, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(290, 46);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Cambridge A.2 Biology (9700) P.P Paper: 5 From 19-24 All Variants.";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DownloadBar
            // 
            this.DownloadBar.AllowAnimations = false;
            this.DownloadBar.Animation = 0;
            this.DownloadBar.AnimationSpeed = 220;
            this.DownloadBar.AnimationStep = 10;
            this.DownloadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.DownloadBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownloadBar.BackgroundImage")));
            this.DownloadBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.DownloadBar.BorderRadius = 9;
            this.DownloadBar.BorderThickness = 1;
            this.DownloadBar.Location = new System.Drawing.Point(113, 96);
            this.DownloadBar.Maximum = 100;
            this.DownloadBar.MaximumValue = 100;
            this.DownloadBar.Minimum = 0;
            this.DownloadBar.MinimumValue = 0;
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.DownloadBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.DownloadBar.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(95)))), ((int)(((byte)(64)))));
            this.DownloadBar.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(95)))), ((int)(((byte)(64)))));
            this.DownloadBar.Size = new System.Drawing.Size(285, 13);
            this.DownloadBar.TabIndex = 4;
            this.DownloadBar.Value = 22;
            this.DownloadBar.ValueByTransition = 22;
            this.DownloadBar.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs>(this.bunifuProgressBar1_ProgressChanged);
            // 
            // DownloadedCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.BorderRadius = 20;
            this.Controls.Add(this.DownloadBar);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BookPic);
            this.Name = "DownloadedCard";
            this.Size = new System.Drawing.Size(452, 127);
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox BookPic;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuProgressBar DownloadBar;
    }
}
