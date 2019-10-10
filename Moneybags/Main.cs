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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            PersonaliseLogin();
        }

        private void PersonaliseLogin()
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
                this.Text = "Welcome back, " + loadedPersona.FirstName;
                welcomeLabel.Text = "What would you like to do?";
            }
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
