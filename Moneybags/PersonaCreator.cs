using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Moneybags
{
    public partial class PersonaCreator : MetroFramework.Forms.MetroForm
    {
        public PersonaCreator()
        {
            InitializeComponent();
            logoPathTB.Enabled = false;
            logoPathTB.Visible = false;
            logoPreview.Visible = false;
            logoBrowseBtn.Visible = false;
            stretchWarningLabel.Visible = false;
            PrefillDataFromLoadedPersona();
        }

        private Persona CreatePersona(string filePath)
        {
            Persona newPersona = new Persona(this.firstNameTB.Text, this.lastNameTB.Text, this.abnTB.Text,
                this.addressLine1TB.Text, this.addressLine2TB.Text, this.postal1TB.Text, this.postal2TB.Text,
                this.accountNumberTB.Text, this.bsbTB.Text, this.useBusinessNameCheckBox.Checked,
                this.useSameAddressCheckBox.Checked, this.useLogoCheckBox.Checked, this.logoPathTB.Text)
            {
                path = filePath
            };
            return newPersona;
        }

        private void SetAsActivePersona(Persona persona)
        {
            FileInfo fileInfo = new FileInfo(@".\currentuser");
            if (!fileInfo.Exists)
            {
                using (StreamWriter streamWriter = fileInfo.CreateText())
                {
                    streamWriter.WriteLine(persona.path);
                }
            }
            else
            {
                File.WriteAllText(@".\currentuser", string.Empty);
                using (StreamWriter streamWriter = fileInfo.CreateText())
                {
                    streamWriter.WriteLine(persona.path);
                }
            }
            Application.Restart();
        }

        private void SaveAndUsePersonaBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Moneybags Persona (*.mbpersona)|*.mbpersona",
                RestoreDirectory = true,
                Title = "Choose a location to save your new Persona",
                DefaultExt = "mbpersona",
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                    Persona newPersona = this.CreatePersona(saveFileDialog.FileName);
                    SetAsActivePersona(newPersona);
                    formatter.Serialize(stream, newPersona);
                    stream.Close();
                    Application.Restart();
                }
                catch (IOException)
                {
                    MessageBox.Show("Unable to save Persona.\r\nPlease ensure you are not attempting to overwrite the Persona you currently have loaded.", "Moneybags - Unable to save Persona");
                }
            }
            
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
                addressLine1TB.Text = loadedPersona.AddressLine1;
                addressLine2TB.Text = loadedPersona.AddressLine2;
                postal1TB.Text = loadedPersona.PostalAddressLine1;
                postal2TB.Text = loadedPersona.PostalAddressLine2;
                accountNumberTB.Text = loadedPersona.AccountNumber.ToString();
                bsbTB.Text = loadedPersona.BSB.ToString();
                useSameAddressCheckBox.Checked = loadedPersona.UseSameAddress;
                useBusinessNameCheckBox.Checked = loadedPersona.IsBusiness;
                useLogoCheckBox.Checked = loadedPersona.UseLogo;
                logoPathTB.Text = loadedPersona.LogoPath;
                if (loadedPersona.UseLogo)
                {
                    setLogoPreview(loadedPersona.LogoPath);
                }
            }
        }

        private void LoadPersonaFromFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RestoreDirectory = true,
                Title = "Load a previously saved Persona",
                DefaultExt = "mbpersona",
                Filter = "Moneybags Persona (*.mbpersona)|*.mbpersona",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                try
                {
                    Persona loadedPersona = (Persona)formatter.Deserialize(stream);
                    SetAsActivePersona(loadedPersona);
                    PrefillDataFromLoadedPersona();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("The Persona you are attempting to open may have been made with an earlier version of Moneybags.\r\nPlease use a different Persona.",
                        "Moneybags - Could not load Persona");
                }

                
            }
        }

        private void useSameAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useSameAddressCheckBox.Checked)
            {
                postal1TB.Text = addressLine1TB.Text;
                postal2TB.Text = addressLine2TB.Text;
                postal1TB.Enabled = false;
                postal2TB.Enabled = false;
            }
            else
            {
                postal1TB.Text = "";
                postal2TB.Text = "";
                postal1TB.Enabled = true;
                postal2TB.Enabled = true;
            }
        }

        private void useBusinessNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useBusinessNameCheckBox.Checked)
            {
                firstNameLabel.Text = "Business Name";
                lastNameLabel.Visible = false;
                lastNameTB.Text = "";
                lastNameTB.Visible = false;
            }
            else
            {
                firstNameLabel.Text = "First Name";
                lastNameLabel.Visible = true;
                lastNameTB.Text = "";
                lastNameTB.Visible = true;
            }
        }

        private void useLogoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useLogoCheckBox.Checked)
            {
                logoPathTB.Visible = true;
                logoPreview.Visible = true;
                logoBrowseBtn.Visible = true;
            }
            else
            {
                logoPathTB.Visible = false;
                logoPreview.Visible = false;
                logoBrowseBtn.Visible = false;
                stretchWarningLabel.Visible = false;
            }
        }

        private void logoBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RestoreDirectory = true,
                Title = "Load an image to use as a Logo",
                DefaultExt = "png",
                Filter = "Image (*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                setLogoPreview(openFileDialog.FileName);
            }
        }

        private void setLogoPreview(string path)
        {
            if (File.Exists(path))
            {
                logoPreview.Image = new Bitmap(path);
                logoPathTB.Text = path;
                if (!logoPreview.Image.Width.Equals(logoPreview.Image.Height))
                {
                    stretchWarningLabel.Visible = true;
                    stretchWarningLabel.Text = "Note: The loaded image is not square.\r\nUsing a square image is recommended to\r\nprevent your logo from appearing stretched.";
                }
                else
                {
                    stretchWarningLabel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Moneybags could not import logo, the file was not found.\r\nPlease try importing the logo again.", 
                    "Moneybags - Could not import logo");
            }
        }
    }
}
