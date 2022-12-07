﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ECommerce
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Grid MainGrid;

        public static void DeleteLastView()
        {
            MainGrid.Children.RemoveAt(MainGrid.Children.Count - 1);
        }
    }
}
