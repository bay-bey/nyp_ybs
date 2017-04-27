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
using System.Data.OleDb;
using System.Data;

namespace WpfAccessBO
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=OkulBO.mdb");
            try
            {
                baglanti.Open();
                DataSet veriKumesi = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Çalışanlar", baglanti);
                da.Fill(veriKumesi, "Çalışanlar");
                CalisanlarGrid.ItemsSource = veriKumesi.Tables["Çalışanlar"].DefaultView;

                baglanti.Close();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Veritabanı bağlantısı oluşturulamadı: "+exc.Message);
            }

        }
    }
}
