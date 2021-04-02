using System;
using System.Windows.Forms;

namespace Moneybags
{
    public partial class ItemCreator : MetroFramework.Forms.MetroForm
    {
        private ListView listView;
        public ItemCreator(ListView listView)
        {
            this.listView = listView;
            InitializeComponent();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            Double total = Math.Round(Convert.ToDouble(this.unitPriceTB.Text) * Convert.ToDouble(this.qtyTB.Text), 2);
            Double gst = Math.Round(total / 11, 2);
            string[] row = {this.itemCodeTB.Text, this.descriptionTB.Text,
            this.unitPriceTB.Text, this.qtyTB.Text, gst.ToString(), total.ToString()};
            ListViewItem listViewItem = new ListViewItem(row);
            this.listView.Items.Add(listViewItem);
            this.Dispose();
        }
    }
}
