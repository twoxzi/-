﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Twoxzi.RemoteManager.Entity;

using System.Runtime.InteropServices;
using System.Configuration;
using System.Windows.Controls;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Data;
using System.Reflection;

namespace Twoxzi.RemoteManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        

        

        

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = this;
            
        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
