using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace dp
{
    public partial class slideshow : PhoneApplicationPage
    {

        private DispatcherTimer tmr = new DispatcherTimer();

        private List<string> images = new List<string>();

        private int imageIndex = 0;


        private DispatcherTimer tmr1 = new DispatcherTimer();

        private List<string> imagess = new List<string>();

        private int imageIndex1 = 0;


        private DispatcherTimer tmr2 = new DispatcherTimer();

        private List<string> imagesss = new List<string>();

        private int imageIndex2 = 0;


        public slideshow()
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

            tmr2.Interval = TimeSpan.FromSeconds(4);
            tmr2.Tick += new EventHandler(tmr2_Tick);
            LoadImages2();
            ShowNextImage2();
        }

        private void LoadImages()
        {
            // list the files (includede in the XAP file) here
            images.Add("/Assets/alp_letters/a.jpg");
            images.Add("/Assets/alp_letters/b.jpg");
            images.Add("/Assets/alp_letters/c.jpg");
            images.Add("/Assets/alp_letters/d.jpg");
            images.Add("/Assets/alp_letters/e.jpg");
            images.Add("/Assets/alp_letters/f.jpg");
            images.Add("/Assets/alp_letters/g.jpg");
            images.Add("/Assets/alp_letters/h.jpg");
            images.Add("/Assets/alp_letters/i.jpg");
            images.Add("/Assets/alp_letters/j.jpg");
            images.Add("/Assets/alp_letters/k.jpg");
            images.Add("/Assets/alp_letters/l.png");
            images.Add("/Assets/alp_letters/m.jpg");
            images.Add("/Assets/alp_letters/n.jpg");
            images.Add("/Assets/alp_letters/o.jpg");
            images.Add("/Assets/alp_letters/p.jpg");
            images.Add("/Assets/alp_letters/q.jpg");
            images.Add("/Assets/alp_letters/r.jpg");
            images.Add("/Assets/alp_letters/s.jpg");
            images.Add("/Assets/alp_letters/t.jpg");
            images.Add("/Assets/alp_letters/u.jpg");
            images.Add("/Assets/alp_letters/v.jpg");
            images.Add("/Assets/alp_letters/w.jpg");
            images.Add("/Assets/alp_letters/x.jpg");
            images.Add("/Assets/alp_letters/y.jpg");
            images.Add("/Assets/alp_letters/z.jpg");
        }

        private void LoadImages1()
        {
            // list the files (includede in the XAP file) here
            imagess.Add("/Assets/alp_images/ap.jpg");
            imagess.Add("/Assets/alp_images/bal.jpg");
            imagess.Add("/Assets/alp_images/ca.jpg");
            imagess.Add("/Assets/alp_images/do.jpg");
            imagess.Add("/Assets/alp_images/ele.jpg");
            imagess.Add("/Assets/alp_images/fi.jpg");
            imagess.Add("/Assets/alp_images/go.jpg");
            imagess.Add("/Assets/alp_images/hor.jpg");        
            imagess.Add("/Assets/alp_images/ice.png");
            imagess.Add("/Assets/alp_images/ju.png");
            imagess.Add("/Assets/alp_images/ka.png");
            imagess.Add("/Assets/alp_images/li.jpg"); 
            imagess.Add("/Assets/alp_images/ma.jpg");
            imagess.Add("/Assets/alp_images/ne.jpg");
            imagess.Add("/Assets/alp_images/ow.jpg");
            imagess.Add("/Assets/alp_images/pe.jpg");
            imagess.Add("/Assets/alp_images/qu.jpg");
            imagess.Add("/Assets/alp_images/ro.jpg");
            imagess.Add("/Assets/alp_images/su.png");
            imagess.Add("/Assets/alp_images/ti.jpg");
            imagess.Add("/Assets/alp_images/um.jpg");
            imagess.Add("/Assets/alp_images/va.jpg");
            imagess.Add("/Assets/alp_images/wa.png");
            imagess.Add("/Assets/alp_images/xa.jpg");
            imagess.Add("/Assets/alp_images/ya.jpg");
            imagess.Add("/Assets/alp_images/ze.jpg");
           
        }

        private void LoadImages2()
        {
            // list the files (includede in the XAP file) here
            imagesss.Add("/Assets/spel_img/app.jpg");
            imagesss.Add("/Assets/spel_img/ballll.png");
            imagesss.Add("/Assets/spel_img/cat.jpg");
            imagesss.Add("/Assets/spel_img/dog.jpg");
            imagesss.Add("/Assets/spel_img/elep.jpg");
            imagesss.Add("/Assets/spel_img/fishhhh.jpg");
            imagesss.Add("/Assets/spel_img/goat.png");
            imagesss.Add("/Assets/spel_img/hors.jpg");
            imagesss.Add("/Assets/spel_img/icecr.jpg");
            imagesss.Add("/Assets/spel_img/jugg.jpg");
            imagesss.Add("/Assets/spel_img/kangroo.jpg");
            imagesss.Add("/Assets/spel_img/lion.jpg");
            imagesss.Add("/Assets/spel_img/mangoo.jpg");
            imagesss.Add("/Assets/spel_img/nst.jpg");
            imagesss.Add("/Assets/spel_img/owlll.jpg");
            imagesss.Add("/Assets/spel_img/peacockkk.jpg"); 
            imagesss.Add("/Assets/spel_img/qu.png");
            imagesss.Add("/Assets/spel_img/rosess.png");
            imagesss.Add("/Assets/spel_img/sunn.jpg");
            imagesss.Add("/Assets/spel_img/tigee.jpg"); 
            imagesss.Add("/Assets/spel_img/umbrla.jpg");
            imagesss.Add("/Assets/spel_img/van.jpg");
            imagesss.Add("/Assets/spel_img/watrmlll.jpg");
            imagesss.Add("/Assets/spel_img/yakkkk.jpg");
            imagesss.Add("/Assets/spel_img/ze.jpg");



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

             private void ShowNextImage2()
             {
                 var biii = new BitmapImage(new Uri(imagesss[imageIndex2], UriKind.Relative));

                 myImg2.Source = biii;

                 imageIndex2 = (imageIndex2 + 1) % imagesss.Count;
             }

        void tmr_Tick(object sender, EventArgs e)
        {
            ShowNextImage();
        }

        void tmr1_Tick(object sender, EventArgs e)
        {
            ShowNextImage1();
        }

        void tmr2_Tick(object sender, EventArgs e)
        {
            ShowNextImage2();
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
             
            if (!tmr2.IsEnabled)
            {
                tmr2.Start();
            }

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            tmr.Stop();

            base.OnNavigatedFrom(e);


            tmr1.Stop();

            base.OnNavigatedFrom(e);
            tmr2.Stop();

            base.OnNavigatedFrom(e);
        }
      
    }
}