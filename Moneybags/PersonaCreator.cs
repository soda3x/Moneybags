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
    public partial class PersonaCreator : MetroFramework.Forms.MetroForm
    {
        public PersonaCreator()
        {
            InitializeComponent();
            PrefillDataFromLoadedPersona();
        }

        private Persona CreatePersona(string filePath)
        {
            Persona newPersona = new Persona(this.firstNameTB.Text, this.lastNameTB.Text, Convert.ToInt64(this.abnTB.Text),
                this.addressLine1TB.Text, this.addressLine2TB.Text, this.postal1TB.Text, this.postal2TB.Text)
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
            } else
            {
                File.WriteAllText(@".\currentuser", string.Empty);
                using (StreamWriter streamWriter = fileInfo.CreateText())
                {
                    streamWriter.WriteLine(persona.path);
                }
            }
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
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                Persona newPersona = this.CreatePersona(saveFileDialog.FileName);
                SetAsActivePersona(newPersona);
                formatter.Serialize(stream, newPersona);
                stream.Close();
            }
            
        }

        private void SavePersonaToFileBtn_Click(object sender, EventArgs e)
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
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, this.CreatePersona(saveFileDialog.FileName));
                stream.Close();
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
                Persona loadedPersona = (Persona)formatter.Deserialize(stream);
                SetAsActivePersona(loadedPersona);
                PrefillDataFromLoadedPersona();
            }
        }
    }
}
