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

        private static MainViewModel instance;

        public static MainViewModel Instance
        {
            get { return MainViewModel.instance; }
            private set { MainViewModel.instance = value; }
        }

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
            if (MainViewModel.instance == null)
            {
                Width = 525;
                Height = 350;
                Threads = new BindingList<DownloadThread>();
                fetch = new DelegateCommand<object>((s) =>
                {
                    Threads.Clear();
                    DownloadThread.Clear();
                    Downloader.count = 0;
                    new DownloadThread(RootURL);
                }, (s) => { return !string.IsNullOrWhiteSpace(RootURL); });

                RootURL = "http://www.apple.com";
                MainViewModel.Instance = this;
            }
            else throw new Exception("There can only be one!!!!!");
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

        public void redraw()
        {

        }

        private int height;
        public int Height { get { return height; } set { height = value; RaisePropertyChanged("Height"); } }

        private int width;
        public int Width { get { return width; } set { width = value; RaisePropertyChanged("Width"); RaisePropertyChanged("NameWidth"); } }

        public int ProgressWidth { get { return 200; } }

        public int NameWidth { get { return Width - ProgressWidth; } }
    }
}
