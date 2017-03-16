using System;
using System.Collections.Generic;
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

namespace HatirlaticiBO
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Zaman z = new Zaman(11, 119, 285);
            Zaman z1 = z.saniyeEkle(500);
            Zaman z3 = new Zaman(01, 10, 25);
            Zaman z2 = z.zamanEkle(z1);
            Zaman z4 = z3.zamanEkle(z);
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(labelaZamaniYaz);
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Start();
        }

        private void labelaZamaniYaz(object sender, RoutedEventArgs e)
        {
            Zaman z = new Zaman(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            lbZaman.Content = z.Saat + ":" + z.Dakika + ":" + z.Saniye;
        }
    }
}
