using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WebCrawler.Model;

namespace WebCrawler.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string siteContent;

        private string fetchUrl;

        private List<String> urls;

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
            fetch = new DelegateCommand<object>((s) => { Downloader.downloadUrl(FetchUrl); }, (s) => { return !string.IsNullOrWhiteSpace(FetchUrl); });
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
