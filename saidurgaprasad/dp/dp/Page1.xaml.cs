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
namespace dp
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private MediaState state = MediaState.Stopped;

      
       

        private void playVideoButton_Click(object sender, RoutedEventArgs e)
        {
            //myMediaElement.Source = new Uri("/Assets/alphabt 1.mp4", UriKind.RelativeOrAbsolute);
            //myMediaElement.Play();
            if (SAI6.user == "dp")
            {
                if (state == MediaState.Stopped)
                {
                    myMediaElement.Source = new Uri("/Assets/alphabt 1.mp4", UriKind.RelativeOrAbsolute);
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
            else if (SAI6.user == "pd")
            {
           if (state == MediaState.Stopped)
                {
                    myMediaElement.Source = new Uri("/Assets/joined-all.mp4", UriKind.RelativeOrAbsolute);
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
        
        private void myMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            state = MediaState.Stopped;
        }
    }
    
}