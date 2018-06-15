using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        DispatcherTimer dt = new DispatcherTimer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Tick;
        }
        private int schetchik=0;
        DateTime dateTime = new DateTime();
        
        private void Dt_Tick(object sender, EventArgs e)
        {
            schetchik++;
            timer1.Content = dateTime.Add(TimeSpan.FromSeconds(schetchik)).ToString("HH:mm:ss");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dt.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer1.Content = "00:00:00";
            schetchik = 0;
            dt.Stop();
            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dt.Stop();
        }
    }
}
