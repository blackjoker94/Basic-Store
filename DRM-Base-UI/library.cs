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
    public partial class library : Form
    {
        public library()
        {
            InitializeComponent();
            filter_dropbox.BorderRadius = 10;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            filter_dropbox.Visible = !filter_dropbox.Visible;
            if (filter_dropbox.Visible)
            {
                filter_dropbox.Focus();

                filter_dropbox.DroppedDown = true;
            }
        }
    }
}
