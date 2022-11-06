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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для Contact.xaml
    /// </summary>
    public partial class Contact : UserControl
    {
        public Contact()
        {
            InitializeComponent();

            Style style = new Style(this);
            CloseButton.Click += style.Close_Click;
            MinimizeButton.Click += style.Minimize_Click;
            MaximizeButton.Click += style.Maximize_Click;

            BorderNavigator borderNavigator = new BorderNavigator();
            menu.Click += borderNavigator.MenuButton_Click;
            restaurant.Click += borderNavigator.RestaurantButton_Click;
            classes.Click += borderNavigator.ClassesButton_Click;
            booking.Click += borderNavigator.BookButton_Click;
        }
        private void MainPage_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new MainPage());
    }
}
