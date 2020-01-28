using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quizek
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newSettings(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
           
            window.Content = new Settings();

            //this.Content = new Game();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.menuGrid.Visibility = Visibility.Hidden;
            this.quitGrid.Visibility = Visibility.Visible;
        }

        private void kill(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void goBackToMenu(object sender, RoutedEventArgs e)
        {
            this.menuGrid.Visibility = Visibility.Visible;
            this.quitGrid.Visibility = Visibility.Hidden;
        }
    }
}
