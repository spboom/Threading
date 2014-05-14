using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebCrawler.Model
{
    class Downloader
    {

        public static void downloadUrl(String fetchUrl)
        {
            WebClient wc = new WebClient();
            String html = wc.DownloadString(fetchUrl);
            List<String> links = new List<string>();
            Regex regx = new Regex(@"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)", RegexOptions.IgnoreCase);
            //String regx = "href=\"(.+)\"";

            foreach (Match match in regx.Matches(html))
            {
                links.Add(match.Value);
            }

            System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\WebCrawler.html", html);
        }

    }
}
