using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Moneybags
{
    public partial class InvoiceCreator : MetroFramework.Forms.MetroForm
    {

        public InvoiceCreator(bool personaLoaded)
        {
            InitializeComponent();
            if (personaLoaded)
            {
                PrefillDataFromLoadedPersona();
            }
            tabControl.SelectedIndex = 0;
            invoiceSuccessLabel.Visible = false;
        }

        private void PrefillDataFromLoadedPersona()
        {
            Persona loadedPersona = this.GetLoadedPersona();
            firstNameTB.Text = loadedPersona.FirstName;
            lastNameTB.Text = loadedPersona.LastName;
            abnTB.Text = loadedPersona.ABN.ToString();
            addr1TB.Text = loadedPersona.AddressLine1;
            addr2TB.Text = loadedPersona.AddressLine2;
            postalAddr1TB.Text = loadedPersona.PostalAddressLine1;
            postalAddr2TB.Text = loadedPersona.PostalAddressLine2;
            accountNumberTB.Text = loadedPersona.AccountNumber.ToString();
            bsbTB.Text = loadedPersona.BSB.ToString();
        }

        private Persona GetLoadedPersona()
        {
            FileInfo fileInfo = new FileInfo(@".\currentuser");
            if (fileInfo.Exists)
            {
                string path = "";
                using (StreamReader streamReader = fileInfo.OpenText())
                {
                    path = streamReader.ReadLine();
                }
                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                return (Persona)formatter.Deserialize(stream);
            } else
            {
                return null;
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            ItemCreator itemCreator = new ItemCreator(this.itemsListView);
            itemCreator.MinimumSize = itemCreator.Size;
            itemCreator.MaximumSize = itemCreator.Size;
            itemCreator.Show();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.itemsListView.Items.Count; ++i)
            {
                if (this.itemsListView.Items[i].Selected)
                {
                    this.itemsListView.Items[i].Remove();
                    --i;
                }
            }
        }

        private void CreateInvoiceBtn_Click(object sender, EventArgs e)
        {
            invoiceSuccessLabel.Visible = false;
            Persona persona = this.GetLoadedPersona();
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "FIRST_NAME", persona.FirstName },
                { "LAST_NAME", persona.LastName },
                { "ABN", persona.ABN.ToString() },
                { "POSTAL_LINE_1", persona.PostalAddressLine1 },
                { "POSTAL_LINE_2", persona.PostalAddressLine2 },
                { "DATE", DateTime.Now.ToShortDateString() },
                { "ADDR_LINE_1", persona.AddressLine1 },
                { "ADDR_LINE_2", persona.AddressLine2 },
                { "ACCOUNT_NO", persona.AccountNumber.ToString() },
                { "BSB", persona.BSB.ToString() }
            };

            HTMLCreator htmlCreator = new HTMLCreator("./HTML/pdf_template.html", this.itemsListView);
            if (htmlCreator.GenerateHTMLFile(dict))
            {
                invoiceSuccessLabel.Text = "Invoice was successfully created.";
                invoiceSuccessLabel.Visible = true;
            } else
            {
                invoiceSuccessLabel.Text = "Invoice could not be created.";
                invoiceSuccessLabel.Visible = true;
            }
            
        }
    }
}
