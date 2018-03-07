using AdaptLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        #endregion

        #region Construction/Initialization
        public MainPage()
        {
            this.InitializeComponent();
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
        }

        private void Button_Gym_Click(object sender, RoutedEventArgs e)
        {
            closeAllGrids();
            Grid_Gym.Visibility = Visibility.Visible;
        }
        #endregion


    }
}
