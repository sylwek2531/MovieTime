﻿using MovieTime.Model;
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

namespace MovieTime.View
{
    /// <summary>
    /// Logika interakcji dla klasy DataView.xaml
    /// </summary>
    public partial class DataView : UserControl
    {
        public DataView(searchMoviesAsync sma)
        {
            InitializeComponent();
            DataContext = sma;
        }
    }
}