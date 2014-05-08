using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string siteContent;

        private string fetchUrl;

        public string FetchUrl
        {
            get
            {
                return fetchUrl;
            }

            set
            {
                fetchUrl = value;
                RaisePropertyChanged("FetchUrl");
                Fetch.RaiseCanExecuteChanged();
            }
        }


        private DelegateCommand<object> fetch;

        public DelegateCommand<object> Fetch
        {
            get { return fetch; }
        }

        public string SiteContent
        {
            get { return siteContent; }
            set
            {
                siteContent = value;
                RaisePropertyChanged("siteContent");
            }
        }

        public MainViewModel()
        {
            fetch = new DelegateCommand<object>((s) => { downloadUrl(); }, (s) => { return !string.IsNullOrWhiteSpace(FetchUrl); });
        }

        private void downloadUrl()
        {
            WebClient wc = new WebClient();
            String html = wc.DownloadString(FetchUrl);

            System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\WebCrawler.html", html);

            SiteContent = html;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
