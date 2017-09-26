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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Form Main;
        private Streamer Saving;
        private string brand, wheels, size, result;
        ListBoxItem builds = new ListBoxItem();
        


        public MainWindow()
        {
            Main = new Form();
            Saving = new Streamer();
            ListBoxItem builds = new ListBoxItem();
            InitializeComponent();
        }

        private void Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            brand = Brand.Text;
            Main.Brand = Brand.Text;
        }

        private void Wheels_TextChanged(object sender, TextChangedEventArgs e)
        {
            wheels = Wheels.Text;
            Main.Wheels = Wheels.Text;
        }


        private void Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            size = Size.Text;
            Main.Size = Size.Text;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            result = Main.builder();
            builds.Content = result;
            listan.Items.Add(result);
            Saving.Final = result;
            Saving.save();

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            listan.Items.Remove(listan.SelectedItem);
            Saving.remove(listan.SelectedIndex.ToString()); //TODO Skriv ut index innehåll
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Saving.closeLogg();
        }

    }
}
