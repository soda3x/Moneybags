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

            ToolTip unitPriceGSTToolTip = new ToolTip();
            unitPriceGSTToolTip.Active = true;
            unitPriceGSTToolTip.AutoPopDelay = 4000;
            unitPriceGSTToolTip.InitialDelay = 600;
            unitPriceGSTToolTip.IsBalloon = true;
            unitPriceGSTToolTip.ToolTipIcon = ToolTipIcon.Info;
            unitPriceGSTToolTip.SetToolTip(unitPriceIncludesGSTLabel, "Leave this Checkbox unchecked to have Moneybags automatically add GST to your Unit Price");
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                if (unitPriceIncludesGSTCheckBox.Checked)
                {
                    total = Math.Round(Convert.ToDouble(this.unitPriceTB.Text) * Convert.ToDouble(this.qtyTB.Text), 2);
                }
                else
                {
                    // Calculate the total and add 10% GST to total
                    total = Math.Round((Convert.ToDouble(this.unitPriceTB.Text) * Convert.ToDouble(this.qtyTB.Text) * 1.1), 2);
                }
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
            catch (FormatException)
            {
                MessageBox.Show("Unable to add item to Invoice, please ensure the item has a unit price and quantity");
            }
        }
    }
}
