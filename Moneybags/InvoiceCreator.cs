using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

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
            if (loadedPersona.IsBusiness)
            {
                firstNameLabel.Text = "Business Name";
                lastNameTB.Text = "";
                lastNameTB.Visible = false;
                lastNameLabel.Visible = false;
            }
            else
            {
                firstNameLabel.Text = "First Name";
                lastNameTB.Visible = true;
                lastNameLabel.Visible = true;
                lastNameTB.Text = loadedPersona.LastName;
            }
            firstNameTB.Text = loadedPersona.FirstName;
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
            }
            else
            {
                return null;
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            ItemCreator itemCreator = new ItemCreator(this.itemsListView, false);
            itemCreator.MinimumSize = itemCreator.Size;
            itemCreator.MaximumSize = itemCreator.Size;
            itemCreator.ShowDialog();
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

        private void ItemsListView_DoubleClick(object sender, EventArgs e)
        {
            // Check if Selected Items count > 0 to avoid ArgumentOutOfRange Exception being thrown later
            if (this.itemsListView.SelectedItems.Count > 0)
            {
                ItemCreator itemCreator = new ItemCreator(this.itemsListView, true);
                itemCreator.MinimumSize = itemCreator.Size;
                itemCreator.MaximumSize = itemCreator.Size;
                itemCreator.ShowDialog();
            }
        }

        private void LoadIncompleteInvoiceBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RestoreDirectory = true,
                Title = "Load a previously saved Invoice",
                DefaultExt = "mbinvoice",
                Filter = "Moneybags Invoice (*.mbinvoice)|*.mbinvoice",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear any items from the invoice before loading from file
                this.itemsListView.Items.Clear();
                string invoiceString = File.ReadAllText(openFileDialog.FileName).Trim();
                string[] invoiceItemsStr = invoiceString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < invoiceItemsStr.Length; ++i)
                {
                    string[] itemStr = invoiceItemsStr[i].Split(';');
                    ListViewItem item = new ListViewItem(itemStr);
                    this.itemsListView.Items.Add(item);
                }
            }
        }

        private void SaveIncompleteInvoiceBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Invoice|*.mbinvoice",
                RestoreDirectory = true,
                Title = "Choose a location to save your Invoice",
                DefaultExt = "mbinvoice",
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, this.InvoiceToCSVString());
            }
        }

        private string InvoiceToCSVString()
        {
            const int ITEM_CODE = 0;
            const int DESC = 1;
            const int UNIT_PRICE = 2;
            const int QTY = 3;
            const int GST = 4;
            const int TOTAL = 5;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.itemsListView.Items.Count; ++i)
            {
                ListViewItem item = this.itemsListView.Items[i];
                sb.Append(item.SubItems[ITEM_CODE].Text + ";");
                sb.Append(item.SubItems[DESC].Text + ";");
                sb.Append(item.SubItems[UNIT_PRICE].Text + ";");
                sb.Append(item.SubItems[QTY].Text + ";");
                sb.Append(item.SubItems[GST].Text + ";");
                sb.Append(item.SubItems[TOTAL].Text + Environment.NewLine);
            }
            return sb.ToString();
        }

        private void CreateInvoiceBtn_Click(object sender, EventArgs e)
        {
            invoiceSuccessLabel.Visible = false;
            Persona persona = this.GetLoadedPersona();
            if (persona.IsBusiness)
            {
                persona.LastName = "";
            }
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
            }
            else
            {
                invoiceSuccessLabel.Text = "Invoice could not be created.";
                invoiceSuccessLabel.Visible = true;
            }

        }
    }
}
