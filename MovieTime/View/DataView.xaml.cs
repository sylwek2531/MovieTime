using MovieTime.Model;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;


namespace MovieTime.View
{

    public partial class DataView : UserControl
    {
        public DataView(searchMoviesAsync sma)
        {
            InitializeComponent();
            DataContext = sma;
        }

      
    }
    public class ImagePath : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path;
            if(value != null)
            {
                path = value.ToString();
            }
            else
            {
                path = "";
            }
            if (string.IsNullOrEmpty(path)){
                return "../Images/none.png";
            }
            else
            {
                return "http://image.tmdb.org/t/p/w400" + path;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
