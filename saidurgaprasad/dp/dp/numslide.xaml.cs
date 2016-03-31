using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.Windows.Media.Imaging;

namespace dp
{
    public partial class numslide : PhoneApplicationPage
    {

        private DispatcherTimer tmr = new DispatcherTimer();

        private List<string> images = new List<string>();

        private int imageIndex = 0;


        private DispatcherTimer tmr1 = new DispatcherTimer();

        private List<string> imagess = new List<string>();

        private int imageIndex1 = 0;



        public numslide()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainPage_Loaded);
        }
        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            tmr.Interval = TimeSpan.FromSeconds(4);
            tmr.Tick += new EventHandler(tmr_Tick);
            LoadImages();
            ShowNextImage();


            tmr1.Interval = TimeSpan.FromSeconds(4);
            tmr1.Tick += new EventHandler(tmr1_Tick);
            LoadImages1();
            ShowNextImage1();

        
        }

        private void LoadImages()
        {
            // list the files (includede in the XAP file) here
            images.Add("/Assets/number/1.jpg");
            images.Add("/Assets/number/2.jpg");
            images.Add("/Assets/number/3.jpg");
            images.Add("/Assets/number/4.jpg");
            images.Add("/Assets/number/5.jpg");
            images.Add("/Assets/number/6.png");
            images.Add("/Assets/number/7.jpg");
            images.Add("/Assets/number/8.jpg");
            images.Add("/Assets/number/9.jpg");
            images.Add("/Assets/number/10.png");
        }

        private void LoadImages1()
        {
            // list the files (includede in the XAP file) here
            imagess.Add("/Assets/numbers/11.jpg");
            imagess.Add("/Assets/numbers/12.png");
            imagess.Add("/Assets/numbers/13.png");
            imagess.Add("/Assets/numbers/14.png");
            imagess.Add("/Assets/numbers/15.png");
            imagess.Add("/Assets/numbers/16.png");
            imagess.Add("/Assets/numbers/17.png");
            imagess.Add("/Assets/numbers/18.jpg");
            imagess.Add("/Assets/numbers/19.png");
            imagess.Add("/Assets/numbers/110.png");

        }

      
        private void ShowNextImage()
        {
            var bi = new BitmapImage(new Uri(images[imageIndex], UriKind.Relative));

            myImg.Source = bi;

            imageIndex = (imageIndex + 1) % images.Count;
        }

        private void ShowNextImage1()
        {
            var bii = new BitmapImage(new Uri(imagess[imageIndex1], UriKind.Relative));

            myImg1.Source = bii;

            imageIndex1 = (imageIndex1 + 1) % imagess.Count;
        }

       

        void tmr_Tick(object sender, EventArgs e)
        {
            ShowNextImage();
        }

        void tmr1_Tick(object sender, EventArgs e)
        {
            ShowNextImage1();
        }

      
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (!tmr.IsEnabled)
            {
                tmr.Start();
            }

            base.OnNavigatedTo(e);

            if (!tmr1.IsEnabled)
            {
                tmr1.Start();
            }

            base.OnNavigatedTo(e);

           
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            tmr.Stop();

            base.OnNavigatedFrom(e);


            tmr1.Stop();

            base.OnNavigatedFrom(e);
           
        }

    }
}