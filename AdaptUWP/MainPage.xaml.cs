using AdaptLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdaptUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        #region Variables
        MisIdiomas CurrentLanguage = MisIdiomas.EN;
        AdaptText TextBlock_Title;

        //core
        private DispatcherTimer coreTimer = new DispatcherTimer();
        public DateTime Time { get; set; }
        private int TimerSeconds = 0;
        private int TimerMinutes = 0;
        private bool isFirstTime = true;
        #endregion

        #region Construction/Initialization
        public MainPage()
        {
            this.InitializeComponent();
            closeAllGrids();
            Grid_MainMenu.Visibility = Visibility.Visible;
        }

        public void init(MisIdiomas lang)
        {
            //set UI based on language
        }
        #endregion


        #region Navigation
        private void closeAllGrids()
        {
            Grid_Core.Visibility = Visibility.Collapsed;
            Grid_Gym.Visibility = Visibility.Collapsed;
            Grid_MainMenu.Visibility = Visibility.Collapsed;
            Grid_FirstUse.Visibility = Visibility.Collapsed;
        }

        private void Button_Core_Click(object sender, RoutedEventArgs e)
        {
            closeAllGrids();
            Grid_Core.Visibility = Visibility.Visible;
            Grid_Core.Background = Grid_MainMenu.Background;
        }

        private void Button_Gym_Click(object sender, RoutedEventArgs e)
        {
            closeAllGrids();
            Grid_Gym.Visibility = Visibility.Visible;
            Grid_Gym.Background = Grid_MainMenu.Background;
        }

        #endregion

        #region Core
        private void nvSample_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void nvSample_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

        }

        private void Button_CoreGo_Click(object sender, RoutedEventArgs e)
        {
            Button_CoreGo.Visibility = Visibility.Collapsed;
            Button_CorePause.Visibility = Visibility.Visible;
            coreTimer.Interval = TimeSpan.FromSeconds(1);
            if (isFirstTime)
            {
                coreTimer.Tick += (object senderX, object eX) =>
                {
                //  Time = DateTime.Now; //formerly checking for "isRealTime" variable
                //  secondHand(Time.Second);
                TimerSeconds++;
                    if (TimerSeconds == 60)
                    {
                        TimerSeconds = 0;
                        TimerMinutes++;
                    }
                    TextBlock_CoreClock.Text = ((TimerMinutes < 10) ? ("0" + TimerMinutes) : TimerMinutes.ToString()) + ":" + ((TimerSeconds < 10) ? ("0" + TimerSeconds) : TimerSeconds.ToString());
                };
                isFirstTime = false;

                //INITIALIZE THE GIFS!!! 
                CoreGifB.UriSource = new Uri(this.BaseUri, "Img/GIF/giphyCats.gif");
                CoreGifA.UriSource = new Uri(this.BaseUri, "Img/GIF/giphyCats2.gif");
                CoreGifBB.Visibility = Visibility.Visible;
                CoreGifAA.Visibility = Visibility.Visible;

            }
            coreTimer.Start();
            changeExercises(30);
        }

        private async void changeExercises(int duration)
        {
            await Task.Delay(TimeSpan.FromSeconds(duration));
            CoreGifB.UriSource = new Uri(this.BaseUri, "Img/GIF/giphyCats2.gif");
            CoreGifA.UriSource = new Uri(this.BaseUri, "Img/GIF/giphyCats.gif");
            TextBlock_CoreName.Text = "Next Exercise";
        }


        private void Button_CorePause_Click(object sender, RoutedEventArgs e)
        {
            TB_CoreGo.Text = "Start";
            Button_CoreGo.Visibility = Visibility.Visible;
            Button_CorePause.Visibility = Visibility.Collapsed;
            coreTimer.Stop();
        }
        #endregion
    }
}
