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

namespace WpfHelloBO
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
            MessageBox.Show("Merhaba "+ad.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (cb1.IsChecked == true)
                MessageBox.Show("Seçili");
            else
                MessageBox.Show("Seçili değil");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Seçili eleman:"+lb1.SelectedItem);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lb1.Items.Add(ad.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lb1.Items.Remove(lb1.SelectedItem);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            lb1.Items.Add(lb2.SelectedItem);
            lb2.Items.Remove(lb2.SelectedItem);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            lb2.Items.Add(lb1.SelectedItem);
            lb1.Items.Remove(lb1.SelectedItem);   
        }






    }
}
