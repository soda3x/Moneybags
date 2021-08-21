using System;
using System.IO;
using System.Net;
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
            CheckForUpdates();
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

        private void CheckForUpdates()
        {
            string ourVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string latestVersionString;
            WebClient wc = new WebClient();

            // Add headers to impersonate a web browser. Some web sites 
            // will not respond correctly without these headers
            wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12");
            wc.Headers.Add("Accept", "*/*");
            wc.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
            wc.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
            try
            {
                latestVersionString = wc.DownloadString("https://raw.githubusercontent.com/soda3x/Moneybags/master/version.txt");

                var checkedVersion = new Version(latestVersionString);
                var currentVersion = new Version(ourVersion);
                var result = checkedVersion.CompareTo(currentVersion);
                if (result > 0)
                {
                    new UpdateAvailableDialog(ourVersion, latestVersionString, updateNotifyLabel).ShowDialog();
                }
            } catch (WebException)
            {
                updateNotifyLabel.Text = "Unable to check for updates, you may not be using the latest version of Moneybags.";
            }
        }
    }
}
