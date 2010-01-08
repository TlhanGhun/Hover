using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Timers;
using System.IO;

namespace BeezleTester
{
    /// <summary>
    /// Interaction logic for BeezleDisplay.xaml
    /// </summary>
    public partial class BeezleDisplay : Window
    {
        public string imagePath = "";

        public BeezleDisplay()
        {
            InitializeComponent();

            if (File.Exists(imagePath))
            {
                ImageSourceConverter imgConv = new ImageSourceConverter();
                string path = imagePath;
                ImageSource imageSource = (ImageSource) imgConv.ConvertFromString(path);
                imageIcon.Source = imageSource;
            }

            imageProgressBar.Visibility = Visibility.Collapsed;
            imageProgressBack.Visibility = Visibility.Collapsed;
            labelText.Visibility = Visibility.Collapsed;
      
        }

        public void setNewIconPath(string iconPath)
        {
            if (File.Exists(iconPath))
            {
                ImageSourceConverter imgConv = new ImageSourceConverter();
                ImageSource imageSource = (ImageSource)imgConv.ConvertFromString(iconPath);
                imageIcon.Source = imageSource;
            }
        }

        public void showText(string text) {
            labelText.Content = text;
            imageProgressBar.Visibility = Visibility.Collapsed;
            imageProgressBack.Visibility = Visibility.Collapsed;
            labelText.Visibility = Visibility.Visible;
        }

        public void closeNotification()
        {
            Storyboard story = (Storyboard)this.FindResource("FadeAway");
            story.Completed += new EventHandler(story_Completed);
            story.Begin();
        }

        public void showProgressBar(int percentage)
        {

            imageProgressBar.Visibility = Visibility.Visible;
            imageProgressBack.Visibility = Visibility.Visible;

            imageProgressBar.Width = (imageProgressBack.ActualWidth / 100) * percentage;
            labelText.Visibility = Visibility.Collapsed;
        }

        public void showIconOnly()
        {
            imageProgressBar.Visibility = Visibility.Collapsed;
            imageProgressBack.Visibility = Visibility.Collapsed;
            labelText.Visibility = Visibility.Collapsed;
        }


        /// <summary>
        /// Closes the window after we're done fading out.
        /// </summary>
        void story_Completed(object sender, EventArgs e)
        {
            this.Close();
        }



        // raised when mouse cursor enters the area occupied by the element
        void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.2;
            //buttonCloseMe.Visibility = Visibility.Visible;
        }

        // raised when mouse cursor leaves the area occupied by the element
        void OnMouseLeaveHandler(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
           // buttonCloseMe.Visibility = Visibility.Hidden;
        }

        // raised when mouse is clicked on window
        void OnMouseDown(object sender, MouseEventArgs e)
        {
            closeNotification();
        }
    }
}
