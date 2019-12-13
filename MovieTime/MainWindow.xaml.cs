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


namespace MovieTime
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }


        //Wyszukiwanie na klikniecie lupy (Dodać lupe)
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.Content = txtSearch.Text;
        }

        // Wyszukiwanie na enter
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                MainLabel.Content = txtSearch.Text;
            }
            
        }

        private void Wyszukiwarka_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.Content = "Wyszukiwarka";
        }

        private void Top500_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.Content = "Top 500";
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.Content = "News";
        }

        private void Komedie_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.Content = "Komedie";
        }


    }

}
