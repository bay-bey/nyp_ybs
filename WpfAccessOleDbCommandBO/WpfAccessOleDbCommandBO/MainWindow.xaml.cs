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
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../OkulBO.mdb");

        public void verileriCek()
        {
            try
            {
                baglanti.Open();
                DataSet veriKumesi = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Çalışanlar", baglanti);
                da.Fill(veriKumesi, "Çalışanlar");
                CalisanlarGrid.ItemsSource = veriKumesi.Tables["Çalışanlar"].DefaultView;
                GuncellemeGrid.ItemsSource = veriKumesi.Tables["Çalışanlar"].DefaultView;
                baglanti.Close();
            }
            catch (Exception exc)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show(exc.Message);
            }

        }


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
                verileriCek();
            }
            catch (Exception exc)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show(exc.Message);
            }
        }

        private void tbTckimlik_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            verileriCek();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButton.YesNo);
                if (sonuc == MessageBoxResult.Yes)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("DELETE FROM Çalışanlar WHERE TCKimlik=@tckimlik", baglanti);
                    var secili = (DataRowView)CalisanlarGrid.SelectedItem;
                    komut.Parameters.AddWithValue("@tckimlik", secili[0]);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verileriCek();
                }
            }
            catch (Exception exc)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show(exc.Message);
            }
        }

        private void GuncellemeGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var secili = (DataRowView)GuncellemeGrid.SelectedItem;
                tbTckimlikG.Text = secili[0].ToString();
                tbAdiG.Text = secili[1].ToString();
                tbSoyadiG.Text = secili[2].ToString();
                tbBirimiG.Text = secili[3].ToString();
                tbGirisTarihiG.Text = secili[4].ToString();
                tbMaasG.Text = secili[5].ToString();
                tbDogumTarihiG.Text = secili[6].ToString();
                tbDogumYeriG.Text = secili[7].ToString();

            }
            catch (Exception)
            {
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                baglanti.Open();
                String sql = "UPDATE Çalışanlar SET Adı=@adi, Soyadı=@soyadi, Birimi=@birimi, GirişTarihi=@giristarihi, Maaşı=@maas, DoğumTarihi=@dogumtarihi, DoğumYeri=@dogumyeri WHERE TCKimlik=@tckimlik";
                //String sql = "UPDATE Çalışanlar SET Adı=@adi, Soyadı=@soyadi, Birimi=@birimi, GirişTarihi=@giristarihi, Maaş=@maas, DoğumTarihi=@dogumtarihi, DoğumYeri=@doğumyeri WHERE TCKimlik=@tckimlik";
                OleDbCommand komut = new OleDbCommand(sql, baglanti);
                
                komut.Parameters.AddWithValue("@adi", tbAdiG.Text);
                komut.Parameters.AddWithValue("@soyadi", tbSoyadiG.Text);
                komut.Parameters.AddWithValue("@birimi", tbBirimiG.Text);
                komut.Parameters.AddWithValue("@giristarihi", tbGirisTarihiG.Text);
                komut.Parameters.AddWithValue("@maas", tbMaasG.Text);
                komut.Parameters.AddWithValue("@dogumtarihi", tbDogumTarihiG.Text);
                komut.Parameters.AddWithValue("@dogumyeri", tbDogumYeriG.Text);
                komut.Parameters.AddWithValue("@tckimlik", tbTckimlikG.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                verileriCek();
            }
            catch (Exception exc)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                MessageBox.Show(exc.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                baglanti.Open();
                String sql = "SELECT * FROM Çalışanlar WHERE Adı LIKE '" + tbSorgula.Text + "%'";
                DataSet kume = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, baglanti);
                da.Fill(kume, "Çalışanlar");
                sorgulaGrid.ItemsSource = kume.Tables["Çalışanlar"].DefaultView;
                //MessageBox.Show(sql);
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
