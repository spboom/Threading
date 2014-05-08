﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebCrawler.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void downloadUrl(String url)
        {
            WebClient wc = new WebClient();
            String html = wc.DownloadString(url);
            label1.Content = html;

            System.IO.File.WriteAllText("..\\..\\..\\..\\TestFiles\\WebCrawler.html", html);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            downloadUrl(fetchURL.Text);
        }
    }
}
