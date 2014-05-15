using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebCrawler.ViewModel;

namespace WebCrawler.Model
{
    class DownloadThread : INotifyPropertyChanged
    {
        public static int MAXVALUE
        {
            get { return 100; }
        }
        private int progress;

        public int Progress
        {
            get { return progress; }
            set
            {
                progress = value;
                RaisePropertyChanged("Progress");
                if (MainViewModel.Instance != null)
                {
                    MainViewModel.Instance.redraw();
                }
            }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set
            {
                name = value; 
                RaisePropertyChanged("Name");
            }
        }

        public DownloadThread(String url)
        {
            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
            {
                MainViewModel.Threads.Add(this);
            });


            Thread t = new Thread(delegate()
            {
                Name = url;
                Downloader.downloadUrl(url, this);
            });

            t.Start();
        }

        public DownloadThread() { }

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
