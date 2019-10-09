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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void CreateNewInvoicePictureBox_Click(object sender, EventArgs e)
        {
            InvoiceCreator invoiceCreator = new InvoiceCreator();
            invoiceCreator.Show();
            invoiceCreator.MinimumSize = invoiceCreator.Size;
        }

        private void ChoosePersonaPictureBox_Click(object sender, EventArgs e)
        {
            PersonaCreator personaCreator = new PersonaCreator();
            personaCreator.Show();
            personaCreator.MinimumSize = personaCreator.Size;
            personaCreator.MaximumSize = personaCreator.Size;
        }
    }
}
