using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneybags
{
    public partial class InvoiceCreator : MetroFramework.Forms.MetroForm
    {
        public InvoiceCreator()
        {
            InitializeComponent();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            ItemCreator itemCreator = new ItemCreator();
            itemCreator.MinimumSize = itemCreator.Size;
            itemCreator.MaximumSize = itemCreator.Size;
            itemCreator.Show();
        }
    }
}
