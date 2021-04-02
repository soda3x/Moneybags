using System;
using System.Windows.Forms;

namespace Moneybags
{
    public partial class ItemCreator : MetroFramework.Forms.MetroForm
    {
        private ListView listView;
        private bool editMode;
        public ItemCreator(ListView listView, bool editMode)
        {
            this.listView = listView;
            this.editMode = editMode;
            InitializeComponent();

            addItemBtn.Text = "Add Item to Invoice";

            if (editMode)
            {
                const int ITEM_CODE = 0;
                const int DESC = 1;
                const int UNIT_PRICE = 2;
                const int QTY = 3;
                itemCodeTB.Text = this.listView.SelectedItems[0].SubItems[ITEM_CODE].Text;
                unitPriceTB.Text = this.listView.SelectedItems[0].SubItems[UNIT_PRICE].Text;
                qtyTB.Text = this.listView.SelectedItems[0].SubItems[QTY].Text;
                descriptionTB.Text = this.listView.SelectedItems[0].SubItems[DESC].Text;
                addItemBtn.Text = "Update Item";
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            Double total = Math.Round(Convert.ToDouble(this.unitPriceTB.Text) * Convert.ToDouble(this.qtyTB.Text), 2);
            Double gst = Math.Round(total / 11, 2);
            string[] row = {this.itemCodeTB.Text, this.descriptionTB.Text,
            this.unitPriceTB.Text, this.qtyTB.Text, gst.ToString(), total.ToString()};
            ListViewItem listViewItem = new ListViewItem(row);
            if (editMode)
            {
                this.listView.Items[this.listView.SelectedIndices[0]] = listViewItem;
            }
            else
            {
                this.listView.Items.Add(listViewItem);
            }
            this.Dispose();
        }
    }
}
