using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            PrefillDataFromLoadedPersona();
        }

        private void PrefillDataFromLoadedPersona()
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
                Persona loadedPersona = (Persona)formatter.Deserialize(stream);
                firstNameTB.Text = loadedPersona.FirstName;
                lastNameTB.Text = loadedPersona.LastName;
                abnTB.Text = loadedPersona.ABN.ToString();
                addr1TB.Text = loadedPersona.AddressLine1;
                addr2TB.Text = loadedPersona.AddressLine2;
                postalAddr1TB.Text = loadedPersona.PostalAddressLine1;
                postalAddr2TB.Text = loadedPersona.PostalAddressLine2;
            }
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
