using MovieTime.Model;
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

<<<<<<< HEAD:MovieTime/MainWindow.xaml.cs

namespace MovieTime
=======
namespace MovieTime.View
>>>>>>> 617b640aca989482c6f48d22e74234c618d8dc0e:MovieTime/View/DataView.xaml.cs
{
    /// <summary>
    /// Logika interakcji dla klasy DataView.xaml
    /// </summary>
<<<<<<< HEAD:MovieTime/MainWindow.xaml.cs
    /// 

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            List<ListItem> list = new List<ListItem>();

            list.Add(new ListItem()
            {

                ID = 1,
                Name = "Wyszukiwarka",
                ImagePath = "Images/loupe.png"
            });

            list.Add(new ListItem()
            {
                ID = 2,
                Name = "Top 500",
                ImagePath = "Images/chart.png"
            });

            list.Add(new ListItem()
            {
                ID = 3,
                Name = "News",
                ImagePath = "Images/newspaper.png"
            });

            list.Add(new ListItem()
            {
                ID = 4,
                Name = "Komedie",
                ImagePath = "Images/grin.png"
            });




            listbox1.ItemsSource = list;
=======
    public partial class DataView : UserControl
    {
        public DataView(searchMoviesAsync sma)
        {
            InitializeComponent();
            DataContext = sma;
>>>>>>> 617b640aca989482c6f48d22e74234c618d8dc0e:MovieTime/View/DataView.xaml.cs
        }

        class ListItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string ImagePath { get; set; }
        }


        //Wyszukiwanie na klikniecie lupy
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

      


    }

}
