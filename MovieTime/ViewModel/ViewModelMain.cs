using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.ViewModel
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));

        }

        string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; NotifyPropertyChanged("MovieName"); }
        }


    }
}
