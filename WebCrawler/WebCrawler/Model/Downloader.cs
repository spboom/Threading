using System;
using System.Net;
using System.Text.RegularExpressions;

namespace WebCrawler.Model
{
    class Downloader
    {
        public static int count = 0;
        public static void downloadUrl(String fetchUrl, DownloadThread callback)
        {
            callback.Progress = 0;
            WebClient wc = new WebClient();
            String html = wc.DownloadString(fetchUrl);
            callback.Progress = 50;
            Regex regx = new Regex(@"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)", RegexOptions.IgnoreCase);
            //String regx = "href=\"(.+)\"";
            callback.Progress = 60;
            foreach (Match match in regx.Matches(html))
            {
                // Removes http://wwww
                string baseDomain = fetchUrl.Substring(10);

                Match match2 = Regex.Match(match.Value, baseDomain, RegexOptions.IgnoreCase);
                if (match2.Success)
                {
                    new DownloadThread(match.Value);
                }
            }
            callback.Progress = 90;
            System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\Download\\" + count++ + ".html", wc.DownloadString(fetchUrl));
            callback.Progress = 100;
        }
    }
}
