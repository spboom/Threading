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
        private string rootURL;

        private List<String> urls;

        public string RootURL
        {
            get
            {
                return rootURL;
            }

            set
            {

                rootURL = value;
                RaisePropertyChanged("RootURL");
                Fetch.RaiseCanExecuteChanged();
            }
        }

        private static BindingList<DownloadThread> threads;

        public static BindingList<DownloadThread> Threads
        {
            get { return threads; }
            set { threads = value; }
        }


        private DelegateCommand<object> fetch;

        public DelegateCommand<object> Fetch
        {
            get { return fetch; }
        }

        public MainViewModel()
        {
            fetch = new DelegateCommand<object>((s) => { Downloader.downloadUrl(RootURL); }, (s) => { return !string.IsNullOrWhiteSpace(RootURL); });
            Threads = new BindingList<DownloadThread>();
            Threads.Add(new DownloadThread() { Name = "Test 0", Progress = 0 });
            Threads.Add(new DownloadThread() { Name = "Test 10", Progress = 10 });
            Threads.Add(new DownloadThread() { Name = "Test 20", Progress = 20 });
            Threads.Add(new DownloadThread() { Name = "Test 30", Progress = 30 });
            Threads.Add(new DownloadThread() { Name = "Test 40", Progress = 40 });
            Threads.Add(new DownloadThread() { Name = "Test 50", Progress = 50 });
            Threads.Add(new DownloadThread() { Name = "Test 60", Progress = 60 });
            Threads.Add(new DownloadThread() { Name = "Test 70", Progress = 70 });
            Threads.Add(new DownloadThread() { Name = "Test 80", Progress = 80 });
            Threads.Add(new DownloadThread() { Name = "Test 90", Progress = 90 });
            Threads.Add(new DownloadThread() { Name = "Test 100", Progress = 100 });
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
