﻿using System;
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
            System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\WebCrawler.html", html);

            List<String> links = new List<string>();
            Regex regx = new Regex(@"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)", RegexOptions.IgnoreCase);
            //String regx = "href=\"(.+)\"";

            int count = 0;
            foreach (Match match in regx.Matches(html))
            {
                links.Add(match.Value);
                count++;
                
                string baseDomain = fetchUrl.Substring(7);

                Match match2 = Regex.Match(match.Value, baseDomain, RegexOptions.IgnoreCase);
                if (match2.Success)
                {
                    Console.WriteLine("Downloading (" + count + ")" + match.Value);
                    System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\Download\\" + count + ".html", wc.DownloadString(match.Value));
                } 
            }
        }
    }
}
