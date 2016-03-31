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
    public partial class voicetest : PhoneApplicationPage
    {
        public voicetest()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           
           SpeechRecognizerUI speechRecognition = new SpeechRecognizerUI();
           SpeechRecognitionUIResult recoResult = await speechRecognition.RecognizeWithUIAsync();

           if (recoResult.ResultStatus == SpeechRecognitionUIStatus.Succeeded)
           {
               //MessageBox.Show(string.Format("You said {0}.", recoResult.RecognitionResult.Text));
              TextBox.Text = (string.Format("You said {0}.", recoResult.RecognitionResult.Text));
          }
          // if (voice3 == "You said One..")
          // {
           //NavigationService.Navigate(new Uri("/blinddum.xaml", UriKind.Relative));
            //  user = "pd";
          // }


       }

        }
    }
