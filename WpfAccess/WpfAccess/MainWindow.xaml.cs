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

namespace WpfAccess
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
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Okul1.mdb");

            try
            {
                baglanti.Open();

                DataSet kume = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Çalışanlar WHERE DoğumYeri='Denizli'", baglanti);

                da.Fill(kume,"Çalışanlar");

                CalisanlarGrid.ItemsSource = kume.Tables["Çalışanlar"].DefaultView;

                baglanti.Close();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Bağlantı gerçekleştirilemedi! "+exc.Message);
                
            }

            
        }
    }
}
