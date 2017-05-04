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

namespace WpfAccessOleDbCommandBO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=OkulBO.mdb");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO Çalışanlar (TCKimlik,Adı,Soyadı,Birimi,GirişTarihi,Maaşı,DoğumTarihi,DoğumYeri) VALUES(@tckimlik,@adi,@soyadi,@birimi,@giristarihi,@maasi,@dogumtarihi,@dogumyeri)", baglanti);
                komut.Parameters.AddWithValue("@tckimlik", tbTckimlik.Text);
                komut.Parameters.AddWithValue("@adi", tbAdi.Text);
                komut.Parameters.AddWithValue("@soyadi", tbSoyadi.Text);
                komut.Parameters.AddWithValue("@birimi", tbBirimi.Text);
                komut.Parameters.AddWithValue("@giristarihi", tbGirisTarihi.Text);
                komut.Parameters.AddWithValue("@maasi", tbMaas.Text);
                komut.Parameters.AddWithValue("@dogumtarihi", tbDogumTarihi.Text);
                komut.Parameters.AddWithValue("@dogumyeri", tbDogumYeri.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
            }
            catch (Exception exc)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show(exc.Message);
            }
        }
    }
}
