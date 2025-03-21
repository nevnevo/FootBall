using FootBall.Services;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FootBall
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LevelSelect : Page
    {
        public LevelSelect()
        {
            this.InitializeComponent();
        }

        private void fLevel_Click(object sender, RoutedEventArgs e)

        {
            GameManager.Level.ballSpeed = 1;
            GameManager.Level.goalSize = 100;
            Frame.Navigate(typeof(Pages.GamePage));
        }

        private void sLevel_Click(object sender, RoutedEventArgs e)
        {
            GameManager.Level.ballSpeed = 2.5;
            GameManager.Level.goalSize = 70;
            Frame.Navigate(typeof(Pages.GamePage));
        }

        private void tLevel_Click(object sender, RoutedEventArgs e)
        {
            GameManager.Level.ballSpeed = 3.5;
            GameManager.Level.goalSize = 50;
            Frame.Navigate(typeof(Pages.GamePage));
        }
    }
}
