using FootBall.Objects;
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

namespace FootBall.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class GamePage : Page
    {
        private int seconds = Constants.totalTime;
        private GameManager Manager;
        private DispatcherTimer _countTimer;
        public GamePage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            Manager = new GameManager(fieldCanvas);
            GameManager.GameEvents.onUpdateScore += Update;
            _countTimer = new DispatcherTimer();
            _countTimer.Interval = TimeSpan.FromSeconds(1);
            _countTimer.Start();
            _countTimer.Tick += _countTimer_Tick;
        }
        private void Update(int arg1, int arg2)
        {
            FirstGroupScore.Text = arg1.ToString();
            SecondGroupScore.Text = arg2.ToString();
            
        }
        private void _countTimer_Tick(object sender, object e)
        {
            
            countTimer.Text = seconds.ToString();
            seconds--;
            if (seconds == 0)
            {
                _countTimer.Stop();
                FirstGroupScoreFinal.Text = FirstGroupScore.Text;
                SecondGroupScoreFinal.Text = SecondGroupScore.Text;
                bananaGrid.Visibility = Visibility.Visible;
            }

                
            

        }

        private void rtMenu_Click(object sender, RoutedEventArgs e)
        {
            bananaGrid.Visibility = Visibility.Collapsed;
            Frame.Navigate(typeof(MainPage));
        }
    }
}
