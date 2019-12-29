using MovieTime.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                return "http://image.tmdb.org/t/p/original" + path;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
