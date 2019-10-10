using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Moneybags
{
    class HTMLCreator
    {
        private string FilePath { get; set; }
        private ListView ListView { get; set; }
        public HTMLCreator(string filePath, ListView listView)
        {
            this.FilePath = filePath;
            this.ListView = listView;
            FileInfo fileInfo = new FileInfo(filePath);
            if (File.Exists(@"./HTML/Output.html"))
            {
                File.Delete(@"./HTML/Output.html");
            }

            fileInfo.CopyTo("./HTML/Output.html");
        }

        public void GenerateHTMLFile(Dictionary<string, string> inputDict)
        {
            string content = File.ReadAllText("./HTML/Output.html");
            content = content.Replace("{FIRST_NAME}", inputDict["FIRST_NAME"]);
            content = content.Replace("{LAST_NAME}", inputDict["LAST_NAME"]);
            content = content.Replace("{ABN}", inputDict["ABN"]);
            content = content.Replace("{POSTAL_LINE_1}", inputDict["POSTAL_LINE_1"]);
            content = content.Replace("{POSTAL_LINE_2}", inputDict["POSTAL_LINE_2"]);
            content = content.Replace("{DATE}", inputDict["DATE"]);
            content = content.Replace("{ADDR_LINE_1}", inputDict["ADDR_LINE_1"]);
            content = content.Replace("{ADDR_LINE_2}", inputDict["ADDR_LINE_2"]);
            File.WriteAllText("./HTML/Output.html", content);

            List<string> rows = new List<string>();
            double gst = 0;
            double total = 0;
            foreach (ListViewItem item in this.ListView.Items)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("<tr>\n");
                stringBuilder.Append("<td>" + item.SubItems[0].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[1].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[2].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[3].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[4].Text + "</td>\n");
                gst += Convert.ToDouble(item.SubItems[4].Text);
                stringBuilder.Append("<td>" + item.SubItems[5].Text + "</td>\n");
                total += Convert.ToDouble(item.SubItems[5].Text);
                stringBuilder.Append("</tr>\n");
                rows.Add(stringBuilder.ToString());
            }
            StringBuilder sb = new StringBuilder();
            foreach (string str in rows)
            {
                sb.Append(str);
            }
            content = content.Replace("{ROWS}", sb.ToString());

            content = content.Replace("{TOTAL_EXCL_GST}", "$" + (total - gst).ToString());
            content = content.Replace("{GST}", "$" + gst.ToString());
            content = content.Replace("{TOTAL_INCL_GST}", "$" + total.ToString());
            content = content.Replace("{AMT_REC}", "$0");
            content = content.Replace("{INV_BAL}", "$" + total.ToString());
            Random random = new Random();
            int invID = random.Next(int.MaxValue);
            content = content.Replace("{INV_NO}", invID.ToString());

            File.WriteAllText("./HTML/Output.html", content);

            var Renderer = new IronPdf.HtmlToPdf();
            var pdf = Renderer.RenderHTMLFileAsPdf("./HTML/Output.html");

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                RestoreDirectory = true,
                Title = "Choose a location to save your report",
                FileName = "TaxInvoice" + inputDict["FIRST_NAME"] + inputDict["LAST_NAME"] + DateTime.Now.ToString("yyyyMMdd"),
                DefaultExt = "pdf",
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdf.SaveAs(saveFileDialog.FileName);
                Process.Start(saveFileDialog.FileName);
            }
        }
    }
}
