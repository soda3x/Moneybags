using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
                if (!File.Exists(path))
                {
                    MessageBox.Show("Could not find Persona file at: " + fileInfo.FullName + "\nPress OK to start without it");
                    File.Delete(@".\currentuser");
                    Application.Restart();
                }
                else
                {
                    FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    IFormatter formatter = new BinaryFormatter();
                    Persona loadedPersona = (Persona)formatter.Deserialize(stream);
                    this.Text = "Welcome back, " + loadedPersona.FirstName;
                    welcomeLabel.Text = "What would you like to do?";
                    choosePersonaLabel.Text = "Choose Persona";
                }
            }
            else
            {
                choosePersonaLabel.Text = "Create a Persona";
            }
        }

        private void CreateNewInvoicePictureBox_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@".\currentuser");
            if (fileInfo.Exists)
            {
                string path = "";
                using (StreamReader streamReader = fileInfo.OpenText())
                {
                    path = streamReader.ReadLine();
                }
                if (!File.Exists(path))
                {
                    InvoiceCreator invoiceCreator = new InvoiceCreator(false);
                    invoiceCreator.Show();
                    invoiceCreator.MinimumSize = invoiceCreator.Size;
                }
                else
                {
                    InvoiceCreator invoiceCreator = new InvoiceCreator(true);
                    invoiceCreator.Show();
                    invoiceCreator.MinimumSize = invoiceCreator.Size;
                }
            }
        }

        private void ChoosePersonaPictureBox_Click(object sender, EventArgs e)
        {
            PersonaCreator personaCreator = new PersonaCreator();
            personaCreator.Show();
            personaCreator.MinimumSize = personaCreator.Size;
            personaCreator.MaximumSize = personaCreator.Size;
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {
            String version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MessageBox.Show("Moneybags\nVersion " + version + "\n\n\nCreated by Bradley Newman");
        }
    }
}
