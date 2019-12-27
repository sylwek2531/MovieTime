
using MovieTime.Controller;
using MovieTime.Model;
using MovieTime.View;
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
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("CLICK");
            if (string.IsNullOrEmpty(viewModel.MovieName))
                return;


            Grid.Children.Add(new DataView(controller.getSearchMovie(viewModel.MovieName)));
         
        }
    }

}
