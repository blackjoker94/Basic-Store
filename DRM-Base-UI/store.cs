using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DRM_Base_UI.JsonStructures;

namespace DRM_Base_UI
{
    public partial class store : Form
    {
        public store()
        {
            InitializeComponent();
            filter_dropbox.BorderRadius = 10;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SearchTextBox.Refresh();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle = 0x02000000;
                return handleparam;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void filter_dropbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void store_Load(object sender, EventArgs e)
        {
            string sampleJsonString = "[{\"_id\":\"vc8vgf8ett\",\"name\":\"Test1\",\"image_path\":\"http://example.com\",\"certificate\":\"Cambridge\",\"grade\":\"Grade5&6\"},{\"_id\":\"9xeixbcfpo\",\"name\":\"Test2\",\"image_path\":\"http://example.com\",\"certificate\":\"Cambridge\",\"grade\":\"Grade7&8\"},{\"_id\":\"p26krf1esj\",\"name\":\"Test3\",\"image_path\":\"http://example.com\",\"certificate\":\"AQA\",\"grade\":\"Grade10\"},{\"_id\":\"jk6kut1esj\",\"name\":\"Test4\",\"image_path\":\"http://example.com\",\"certificate\":\"AQA\",\"grade\":\"Grade10\"}]";

            var result = JsonConvert.DeserializeObject<List<Book>>(sampleJsonString);

            foreach (var item in result)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.image_path);
            }

            /// Clear Current Controls
            for (int i = TableCards.Controls.Count - 1; i >= 0; --i)
                TableCards.Controls[i].Dispose();

            TableCards.Controls.Clear();
            TableCards.RowCount = 0;
            /// End Clear

            TableCards.ColumnCount = 3;
            TableCards.RowCount = 1;

            TableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            TableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            TableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            TableCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            int index = 0;

            foreach (var item in result)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.image_path);
                var productCard = new ProductCard(item.name, "$0", item.image_path, new List<string>());
                TableCards.Controls.Add(productCard, index, TableCards.RowCount - 1);
                index++;
            }

        }
    }
}

public class TableCards : TableLayoutPanel
{
    public TableCards()
    {
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    }
}