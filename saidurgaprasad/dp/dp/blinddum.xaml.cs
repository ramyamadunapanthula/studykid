using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.Media;

namespace dp
{
    public partial class blinddum : PhoneApplicationPage
    {
        public blinddum()
        {

            InitializeComponent();
            if (sai3.user == "pd")
            {
                textblock.Text = "ALPHABETS";
            }
            else if (sai3.user == "dp")
            {
                textblock.Text = "NUMBERS";
            }

            if (sai3.user == "dp")
           {
                myMediaElement.Source = new Uri("/Assets/voices/alp.MP3", UriKind.RelativeOrAbsolute);
              myMediaElement.Play();
           }
           else if (sai3.user == "pd")
           {
                myMediaElement.Source = new Uri("/Assets/voices/speech.mp3", UriKind.RelativeOrAbsolute);
               myMediaElement.Play();
            }
          
        }

        private MediaState state = MediaState.Stopped;
        private void playSoundButton_Click(object sender, RoutedEventArgs e)
        {
            if (sai3.user=="dp")
            {
                //myMediaElement.Source = new Uri("/Assets/h4.mp3", UriKind.RelativeOrAbsolute);
                //myMediaElement.Play();
                if (state == MediaState.Stopped)
                {
                    myMediaElement.Source = new Uri("/Assets/joined-all - song.mp3", UriKind.RelativeOrAbsolute);
                    myMediaElement.Source = new Uri("/Assets/joined-all - song.mp3", UriKind.RelativeOrAbsolute);
                    myMediaElement.Source = new Uri("/Assets/joined-all - song.mp3", UriKind.RelativeOrAbsolute);
                    state = MediaState.Playing;
                    myMediaElement.Play();
                }
                else if (state == MediaState.Playing)
                {
                    state = MediaState.Paused;
                    myMediaElement.Pause();

                }
                else if (state == MediaState.Paused)
                {
                    state = MediaState.Playing;
                    myMediaElement.Play();
                }
               
            }
            else if (sai3.user == "pd")
            {
                if (state == MediaState.Stopped)
                {
                    myMediaElement.Source = new Uri("/Assets/alphabt 1.mp3", UriKind.RelativeOrAbsolute);
                    state = MediaState.Playing;
                    myMediaElement.Play();
                }
                else if (state == MediaState.Playing)
                {
                    state = MediaState.Paused;
                    myMediaElement.Pause();

                }
                else if (state == MediaState.Paused)
                {
                    state = MediaState.Playing;
                    myMediaElement.Play();
                }
            }

        }

       

    }
    public enum MediaState
    {
        Stopped,
        Playing,
        Paused
    }
}
