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
        /// <summary>
        /// Wyświetlanie zdjecia
        /// </summary>
        /// <remarks>Zależnie od tego co dostaniemy w odpowiedzi na nasze żadanie wyświetla nam zdjęcie ktore jest w opisie filmu, lub jeśli nie ma zdjęcia wstawiamy nasze zdjecie none.png zeby nie wysypało opisu</remarks>
        /// <returns>Image</returns>
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
