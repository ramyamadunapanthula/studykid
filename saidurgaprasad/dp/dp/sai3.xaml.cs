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
    public partial class sai3 : PhoneApplicationPage
    {
        public static string user = "";
        public static string voice3 = "";
        public static string alpha = "";
        public sai3()
        {
            InitializeComponent();
            myMediaElement.Source = new Uri("/Assets/voices/screen rotation.MP3", UriKind.RelativeOrAbsolute);
            myMediaElement.Play();
            myMediaElement.Source = new Uri("/Assets/voices/numoralp.MP3", UriKind.RelativeOrAbsolute);
            myMediaElement.Play();
        }
        private MediaState state = MediaState.Stopped;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public  void HyperlinkButton_Click(object sender, RoutedEventArgs e)
       // public async void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
          //  SpeechRecognizerUI speechRecognition = new SpeechRecognizerUI();
          //  SpeechRecognitionUIResult recoResult = await speechRecognition.RecognizeWithUIAsync();
          //  if (recoResult.ResultStatus == SpeechRecognitionUIStatus.Succeeded)
         //   {
                //MessageBox.Show(string.Format("You said {0}.", recoResult.RecognitionResult.Text));
            //    voice3 = (string.Format("You said {0}.", recoResult.RecognitionResult.Text));
          // }
           // if (voice3 == "You said Numbers..")
           // {
                NavigationService.Navigate(new Uri("/blinddum.xaml", UriKind.Relative));
                user = "dp";
           // }

        }

      
          public  void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
      // public async void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
       {
          // SpeechRecognizerUI speechRecognition = new SpeechRecognizerUI();
           //SpeechRecognitionUIResult recoResult = await speechRecognition.RecognizeWithUIAsync();

          // if (recoResult.ResultStatus == SpeechRecognitionUIStatus.Succeeded)
          // {
               //MessageBox.Show(string.Format("You said {0}.", recoResult.RecognitionResult.Text));
             //  voice3 = (string.Format("You said {0}.", recoResult.RecognitionResult.Text));
         //  }
          // if (voice3 == "You said One..")
          // {
             NavigationService.Navigate(new Uri("/blinddum.xaml", UriKind.Relative));
              user = "pd";
          // }


       }
          private void myMediaElement_MediaEnded(object sender, RoutedEventArgs e)
          {
              state = MediaState.Stopped;
          }
       
    }
}