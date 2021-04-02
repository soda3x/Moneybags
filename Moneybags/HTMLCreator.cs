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

        public bool GenerateHTMLFile(Dictionary<string, string> inputDict)
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
            content = content.Replace("{ACCOUNT_NO}", inputDict["ACCOUNT_NO"]);
            content = content.Replace("{BSB}", inputDict["BSB"]);
            File.WriteAllText("./HTML/Output.html", content);

            List<string> rows = new List<string>();
            double gst = 0;
            double total = 0;

            const int ITEM_CODE = 0;
            const int DESC = 1;
            const int UNIT_PRICE = 2;
            const int QTY = 3;
            const int GST = 4;
            const int TOTAL = 5;

            foreach (ListViewItem item in this.ListView.Items)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("<tr>\n");
                stringBuilder.Append("<td>" + item.SubItems[ITEM_CODE].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[DESC].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[UNIT_PRICE].Text + "</td>\n");
                stringBuilder.Append("<td>" + item.SubItems[QTY].Text + "</td>\n");

                stringBuilder.Append("<td>" + item.SubItems[GST].Text + "</td>\n");
                gst += Convert.ToDouble(item.SubItems[GST].Text);

                stringBuilder.Append("<td>" + item.SubItems[TOTAL].Text + "</td>\n");
                total += Convert.ToDouble(item.SubItems[TOTAL].Text);

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

            PDFCreator pdfCreator = new PDFCreator("./HTML/Output.html", inputDict);
            return pdfCreator.GeneratePDFFile();
        }
    }
}
