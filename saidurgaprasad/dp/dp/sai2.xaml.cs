using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Phone.Speech.Recognition;

namespace dp
{
     
    public partial class sai2 : PhoneApplicationPage
    {
        public static string voice1 = "";
        public sai2()
        {
            InitializeComponent();
            myMediaElement.Source = new Uri("/Assets/voices/CreateSpeech_4.MP3", UriKind.RelativeOrAbsolute);
            myMediaElement.Play();
        }

        private MediaState state = MediaState.Stopped;

      // private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
       // {
      //     NavigationService.Navigate(new Uri("/sai3.xaml",UriKind.Relative));

     //  }

        public  void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        //public async void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
           // SpeechRecognizerUI speechRecognition = new SpeechRecognizerUI();
           // SpeechRecognitionUIResult recoResult = await speechRecognition.RecognizeWithUIAsync();

           // if (recoResult.ResultStatus == SpeechRecognitionUIStatus.Succeeded)
           // {
                //MessageBox.Show(string.Format("You said {0}.", recoResult.RecognitionResult.Text));
           //     voice1 = (string.Format("You said {0}.", recoResult.RecognitionResult.Text));
           // }
           // if (voice1 == "You said Go..")
            //{
                NavigationService.Navigate(new Uri("/sai3.xaml", UriKind.Relative));
            //}


        }

      
       private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
       {
           NavigationService.Navigate(new Uri("/sai5.xaml", UriKind.Relative));
       }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sai6.xaml",UriKind.Relative));
        }

        private void myMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            state = MediaState.Stopped;
        }
    }
}