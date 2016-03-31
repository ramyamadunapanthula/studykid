using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using dp.Resources;
using System.Windows.Threading;
using Windows.Phone.Speech.Recognition;

namespace dp
{
    public partial class MainPage : PhoneApplicationPage
    {
       // private DispatcherTimer timer;
        public static string voice = "";
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(2);
            //timer.Tick+=(s,e)=>{
            //   var frame=App.Current.RootVisual as PhoneApplicationFrame;
            //   frame.Navigate(new Uri("/sai2.xaml", UriKind.Relative));
            //};
            //timer.Start();

        }






            //  public async void SpeechToText_Click(object sender, RoutedEventArgs e)
        //{
      //      SpeechRecognizerUI speechRecognition = new SpeechRecognizerUI();
           // SpeechRecognitionUIResult recoResult = await speechRecognition.RecognizeWithUIAsync();

          //  if (recoResult.ResultStatus == SpeechRecognitionUIStatus.Succeeded)
          //  {
               //MessageBox.Show(string.Format("You said {0}.", recoResult.RecognitionResult.Text));
          //   voice=(string.Format("You said {0}.", recoResult.RecognitionResult.Text));
          //  }
          //   if (voice == "You said Good..")
          //  {
         //      NavigationService.Navigate(new Uri("/sai2.xaml", UriKind.Relative));
         //  }
           

       // }

              private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
              {
                  NavigationService.Navigate(new Uri("/sai2.xaml", UriKind.Relative));
              }

              private void SpeechToText_Click(object sender, RoutedEventArgs e)
              {
                  NavigationService.Navigate(new Uri("/sai2.xaml", UriKind.Relative));
              }

            
              
      
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
       

       


        
        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}