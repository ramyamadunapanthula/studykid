using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace dp
{
    public partial class SAI6 : PhoneApplicationPage
    {
           public static string user = "";
        public SAI6()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
             user = "dp";
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
             user = "pd";
        }
        

     
    }
}