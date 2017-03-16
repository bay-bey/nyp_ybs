using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void labelaZamaniYaz(object sender, EventArgs e)
        {
            Zaman mevcutZaman = new Zaman(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            lbZaman.Content = mevcutZaman.ToString();
            foreach (Zaman listedekiZaman in lbHatirlatma.Items)
            {
                if (mevcutZaman.Equals(listedekiZaman))
                {
                    (new Thread(() => MessageBox.Show(listedekiZaman.aciklama))).Start();
                }
                if (mevcutZaman.saniyeEkle(180).Equals(listedekiZaman))
                {
                    (new Thread(() => MessageBox.Show("Hatırlatıcı yaklaşıyor"+listedekiZaman))).Start();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zaman z = new Zaman(int.Parse(tbSaat.Text), int.Parse(tbDakika.Text), int.Parse(tbSaniye.Text));
            z.aciklama = tbAciklama.Text;
            lbHatirlatma.Items.Add(z);
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Zaman z = (Zaman)lbHatirlatma.Items[0];
            //lbHatirlatma.Items.Add(z.saniyeEkle(300));
            Zaman z = new Zaman(1, 2, 3);
            MessageBox.Show("Hatırlatıcı: " + z);
        }
    }
}
