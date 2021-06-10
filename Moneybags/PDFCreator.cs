using Pechkin;
using Pechkin.Synchronized;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Moneybags
{
    class PDFCreator
    {
        private string pathToHTML { get; set; }
        private Dictionary<string, string> metadata;
        public PDFCreator(string pathToHTML, Dictionary<string, string> metadata)
        {
            this.pathToHTML = pathToHTML;
            this.metadata = metadata;
        }

        public bool SaveByteArrayToPDFFile(string fileName, byte[] byteArray)
        {
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                fileStream.Write(byteArray, 0, byteArray.Length);
                fileStream.Close();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public bool GeneratePDFFile()
        {
            GlobalConfig globalConfig = new GlobalConfig();
            globalConfig.SetMargins(new Margins(100, 100, 100, 100))
                .SetDocumentTitle("")
                .SetPaperSize(PaperKind.A4);

            IPechkin pechkin = new SynchronizedPechkin(globalConfig);

            ObjectConfig configuration = new ObjectConfig();
            configuration
                .SetAllowLocalContent(true)
                .SetPageUri(pathToHTML)
                .SetPrintBackground(true)
                .SetScreenMediaType(true);

            byte[] pdfContent = pechkin.Convert(configuration);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                RestoreDirectory = true,
                Title = "Choose a location to save your report",
                FileName = "TaxInvoice" + metadata["FIRST_NAME"] + metadata["LAST_NAME"] + DateTime.Now.ToString("yyyyMMdd"),
                DefaultExt = "pdf",
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (SaveByteArrayToPDFFile(saveFileDialog.FileName, pdfContent))
                {
                    Process.Start(saveFileDialog.FileName);
                    return true;
                } else
                {
                    return false;
                }
                
            } else
            {
                return false;
            }
        }


    }
}
