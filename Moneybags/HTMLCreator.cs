using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Moneybags
{
    class HTMLCreator
    {
        private string FilePath { get; set; }
        public HTMLCreator(string filePath)
        {
            this.FilePath = filePath;
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
            content = content.Replace("{INV_NO}", inputDict["INV_NO"]);
            content = content.Replace("{DATE}", inputDict["DATE"]);
            content = content.Replace("{ADDR_LINE_1}", inputDict["ADDR_LINE_1"]);
            content = content.Replace("{ADDR_LINE_2}", inputDict["ADDR_LINE_2"]);
            content = content.Replace("{TOTAL_EXCL_GST}", inputDict["TOTAL_EXCL_GST"]);
            content = content.Replace("{GST}", inputDict["GST"]);
            content = content.Replace("{TOTAL_INCL_GST}", inputDict["TOTAL_INCL_GST"]);
            content = content.Replace("{AMT_REC}", inputDict["AMT_REC"]);
            content = content.Replace("{INV_BAL}", inputDict["INV_BAL"]);
            File.WriteAllText("./HTML/Output.html", content);
        }
    }
}
