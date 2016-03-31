using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SoundVideo.Resources;

namespace SoundVideo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private MediaState state = MediaState.Stopped;

        private void playSoundButton_Click(object sender, RoutedEventArgs e)
        {
           myMediaElement.Source = new Uri("/Assets/h4.mp3", UriKind.RelativeOrAbsolute);
           myMediaElement.Play();
        }

        private void playVideoButton_Click(object sender, RoutedEventArgs e)
        {
            //myMediaElement.Source = new Uri("/Assets/alphabt 1.mp4", UriKind.RelativeOrAbsolute);
            //myMediaElement.Play();

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
            else if ( state == MediaState.Paused)
            {
                state = MediaState.Playing;
                myMediaElement.Play();
            }

        }

        private void myMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            state = MediaState.Stopped;
        }

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
    public enum MediaState
    {
        Stopped,
        Playing,
        Paused
    }
}