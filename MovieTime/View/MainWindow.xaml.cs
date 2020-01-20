
using MovieTime.Controller;
using MovieTime.Model;
using MovieTime.View;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;


namespace MovieTime
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerMain controller;
        searchPage viewModel;
        public MainWindow()
        {
            controller = new ControllerMain();
            viewModel = new searchPage();
            InitializeComponent();
            this.DataContext = viewModel;

            List<ListItem> list = new List<ListItem>();

            list.Add(new ListItem()
            {

                ID = 1,
                Name = "Wyszukiwarka",
                ImagePath = "../Images/loupe.png"
            });

            list.Add(new ListItem()
            {
                ID = 2,
                Name = "Top 500",
                ImagePath = "../Images/chart.png"
            });

            list.Add(new ListItem()
            {
                ID = 3,
                Name = "News",
                ImagePath = "../Images/newspaper.png"
            });

            list.Add(new ListItem()
            {
                ID = 4,
                Name = "Komedie",
                ImagePath = "../Images/grin.png"
            });

            listbox1.ItemsSource = list;
        }

        class ListItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string ImagePath { get; set; }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.MovieName))
                return;

         
            searchMoviesAsync data = controller.getSearchMovie(viewModel.MovieName);

            if(data.TotalCount > 0)
            {
                Grid.Children.Clear();
                Grid.Children.Add(new DataView(data));
            }
            else
            {
                Grid.Children.Clear();
                Grid.Children.Add(new LabelView());
            }
         
        }


    }

}
