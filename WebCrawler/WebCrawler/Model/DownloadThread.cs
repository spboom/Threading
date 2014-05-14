using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebCrawler.Model
{
    class DownloadThread
    {
        private int progress;

        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
