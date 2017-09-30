using System.Windows;
using System.Windows.Controls;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///

    public partial class MainWindow : Window
    {
        private Builder build;
        private Streamer logg;
        private ListBoxItem builds = new ListBoxItem();

        public MainWindow()
        {
            build = new Builder();
            logg = new Streamer();
            ListBoxItem builds = new ListBoxItem();
            InitializeComponent();
        }

        private void Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            build.Brand = Brand.Text;
        }

        private void Wheels_TextChanged(object sender, TextChangedEventArgs e)
        {
            build.Wheels = Wheels.Text;
        }

        private void Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            build.Size = Size.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string result = build.builder();      //Stringbuilder som sen läggs in i en listbox (listan)
            builds.Content = result;
            listan.Items.Add(result);
            logg.Final = result;                  //Lägger till resultatet i loggen
            logg.AddLogg();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            string temp = listan.SelectedItem.ToString();
            logg.RemoveLogg(temp);                          //Tar bort från listbox och lägger till en kommentar i loggen
            listan.Items.Remove(listan.SelectedItem);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            logg.SaveLogg();   //Stänger steamwriter
        }
    }
}