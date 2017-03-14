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

namespace Hatirlatici
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

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            /*
             * Windows Forms uygulamalarında Timer bir bileşen olarak bulunmaktadır.
             * WPF uygulamalarında ise bunu kodla yapmamız gerekmektedir.
             * 1) DispatcherTimer tipinde bir nesne oluşturulur
             * 2) Bu nesnenin Tick özelliğine çalışmasını istediğimiz metod eklenir
             * 3) Bu nesnenin Interval özelliğine hangi aralıklarla zamanlayıcının 
             *    çalışacağı belirtilir
             * 4) Zamanlayıcı başlatılır
             */ 
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(textBoxaZamanYaz);
            dt.Interval = new TimeSpan(0, 0, 1);//Her 1 sn'de aktif olacak
            dt.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zaman z = new Zaman(int.Parse(tbSaat.Text), int.Parse(tbDakika.Text), int.Parse(tbSaniye.Text));
            z.Aciklama = tbAciklama.Text;
            //hatirlaticiListesi.Items.Add(z);
            hl.Items.Add(z);

            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            /*
             * Bu kısım deneme amaçlı oluşturuldu. Gerekli değil.
             */ 
            //Zaman z = (Zaman)hatirlaticiListesi.Items[0];
            //hl.Items.Add(z);
            //hatirlaticiListesi.Items.Add(z.saniyeEkle(600));

        }

        private void textBoxaZamanYaz(object sender, EventArgs e)
        {
            Zaman mevcutZaman = new Zaman(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            lbSaat.Content = mevcutZaman.ToString();

            
            /*
             * ListBox veya ListView'a elemanları eklerken Zaman tipindeki nesneler
             * olarak ekledik. Aşağıdaki foreach döngüsü ile elemanları Zaman tipinde
             * nesneler olarak alabiliriz. Yani aşağıdaki döngü ile ListBox veya
             * ListView'daki elemanlara Zaman nesneleri olarak erişebilmekteyiz.
             */ 
            //foreach (Zaman listedekiZaman in hatirlaticiListesi.Items)
            foreach (Zaman listedekiZaman in hl.Items)
            {
                if(mevcutZaman.saniyeEkle(180).Equals(listedekiZaman))//Hatırlatıcının zamanına 3 dakika kala başka uyarı veriyoruz.
                    new Thread(() => MessageBox.Show("Hatırlatıcı yaklaşıyor:"+listedekiZaman)).Start();//MessageBox.Show kodu blokladığı için bu şekilde yazıldı

                if (mevcutZaman.Equals(listedekiZaman))//Equals metoduyla iki zamanı karşılaştırabiliyoruz.
                    new Thread(() => MessageBox.Show(listedekiZaman.ToString())).Start();
            }

        }
    }
}
