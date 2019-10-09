using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneybags
{
    class HTMLCreator
    {
        private string FilePath {get; set;}
        public HTMLCreator(string filePath)
        {
            this.FilePath = filePath;
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.CopyTo("Output.html");
        }

        public void GenerateHTMLFile(Dictionary<string, string> keyValuePairs)
        {
            string content = File.ReadAllText("./Output.html");
            content = content.Replace("{FIRST_NAME}", keyValuePairs.ElementAt(0).ToString());
            content = content.Replace("{LAST_NAME}", keyValuePairs.ElementAt(1).ToString());
            content = content.Replace("{ABN}", keyValuePairs.ElementAt(2).ToString());
            content = content.Replace("{POSTAL_LINE_1}", keyValuePairs.ElementAt(3).ToString());
            content = content.Replace("{POSTAL_LINE_2}", keyValuePairs.ElementAt(4).ToString());
            content = content.Replace("{INV_NO}", keyValuePairs.ElementAt(5).ToString());
            content = content.Replace("{DATE}", keyValuePairs.ElementAt(6).ToString());
            content = content.Replace("{ADDR_LINE_1}", keyValuePairs.ElementAt(7).ToString());
            content = content.Replace("{ADDR_LINE_2}", keyValuePairs.ElementAt(8).ToString());
            content = content.Replace("{TOTAL_EXCL_GST}", keyValuePairs.ElementAt(9).ToString());
            content = content.Replace("{GST}", keyValuePairs.ElementAt(10).ToString());
            content = content.Replace("{TOTAL_INCL_GST}", keyValuePairs.ElementAt(11).ToString());
            content = content.Replace("{AMT_REC}", keyValuePairs.ElementAt(12).ToString());
            content = content.Replace("{INV_BAL}", keyValuePairs.ElementAt(13).ToString());
            File.WriteAllText("./Output.html", content);
        }
    }
}
