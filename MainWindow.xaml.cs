﻿
using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public interface ISwitchable { void UtilizeState(object state); }
    public static class Switcher
    {
        public static MainWindow pageSwitcher;
        public static void Switch(UserControl newPage) => pageSwitcher.Navigate(newPage);
        public static void Switch(UserControl newPage, object state) => pageSwitcher.Navigate(newPage, state);
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Switcher.pageSwitcher = this;
            Switcher.Switch(new MainPage());
        }
        public void Navigate(UserControl nextPage) => this.Content = nextPage; 
        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;
            if (s != null) s.UtilizeState(state);
            else throw new ArgumentException("NextPage is not ISwitchable! " + nextPage.Name.ToString());
        }
    }
}
