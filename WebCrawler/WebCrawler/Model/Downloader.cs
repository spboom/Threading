using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebCrawler.Model
{
    class Downloader
    {
        public static int count = 0;
        public static void downloadUrl(String fetchUrl, DownloadThread callback)
        {
            String html = "";
            try
            {
                callback.Progress = 0;
                WebClient wc = new WebClient();
                html = wc.DownloadString(fetchUrl);
            }
            catch (Exception e)
            {
                callback.Progress = -1;
                return;
            }
            callback.Progress = 50;
            Regex regx = new Regex(@"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)", RegexOptions.IgnoreCase);
            //String regx = "href=\"(.+)\"";
            callback.Progress = 60;
            foreach (Match match in regx.Matches(html))
            {
                // Removes http://wwww
                string baseDomain = fetchUrl.Substring(10);

                // Make folder named after baseDomain

                Match match2 = Regex.Match(match.Value, baseDomain, RegexOptions.IgnoreCase);
                if (match2.Success)
                {
                    if (DownloadThread.addURL(match.Value))
                    {
                        Thread t = new Thread(delegate()
                            {
                                new DownloadThread(match.Value);
                            });
                        t.Start();
                    }
                }
            }
            callback.Progress = 90;
            // Make folder named after subdomain (www/images/developers/)
            // Make folders for all folders after baseURL (apple.com/images, apple.com/a/folder/to/somewhere)
            Console.WriteLine("Downloading (" + count + ")" + fetchUrl);
            System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\Download\\" + count++ + ".html", html);
            callback.Progress = 100;
        }
    }
}
