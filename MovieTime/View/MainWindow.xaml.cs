
using MovieTime.Controller;
using MovieTime.Model;
using MovieTime.View;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
                Name = "Playing Now",
                ImagePath = "../Images/play.png"
            });

            list.Add(new ListItem()
            {
                ID = 2,
                Name = "Top",
                ImagePath = "../Images/star.png"
            });

            list.Add(new ListItem()
            {
                ID = 3,
                Name = "Popular",
                ImagePath = "../Images/popular.png"
            });

            list.Add(new ListItem()
            {
                ID = 4,
                Name = "Upcoming",
                ImagePath = "../Images/upcoming.png"
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

            display_data(data);
            listbox1.UnselectAll();

        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchBox.Text = String.Empty;
            var item = (ListBox)sender;
            var value = (ListItem)item.SelectedItem;
            if(value != null) { 
                switch (value.ID)
                {
                    case 1:
                         searchMoviesAsync dataNowPlaying = controller.getNowPlaying();
                         display_data(dataNowPlaying);
                        break;
                    case 2:
                        searchMoviesAsync dataTopRated = controller.getTopRated();
                        display_data(dataTopRated);
                        break;
                    case 3:
                        searchMoviesAsync dataPopular = controller.getPopular();
                        display_data(dataPopular);
                        break;
                    case 4:
                        searchMoviesAsync dataUpcoming = controller.getUpcoming();
                        display_data(dataUpcoming); ;
                        break;
                    default:
                        break;
                }
            }

        }
        private void display_data(searchMoviesAsync data)
        {
            if (data.TotalCount > 0)
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
