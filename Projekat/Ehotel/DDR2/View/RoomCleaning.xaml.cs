﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DDR2.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RoomCleaning : Page
    {
        public RoomCleaning()
        {
            this.InitializeComponent();
        }

        private void btnAllRooms_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCleanedRoom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava), e);
        }
    }
}