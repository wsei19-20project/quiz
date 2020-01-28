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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            string difficulty = "";
            string category = "";

            if (EasyBtn.IsChecked == true)
                difficulty = "easy";
            else if (MediumBtn.IsChecked == true)
                difficulty = "medium";
            else if (HardBtn.IsChecked == true)
                difficulty = "hard";

            if (cat_9.IsChecked == true)
                category = "9";
            else if (cat_18.IsChecked == true)
                category = "18";
            else if (cat_21.IsChecked == true)
                category = "21";
            else if (cat_23.IsChecked == true)
                category = "23";
            else if (cat_24.IsChecked == true)
                category = "24";
            else if (cat_28.IsChecked == true)
                category = "28";


            window.Content = new Game(category, difficulty);
        }

        private void backToMenu(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            window.Content = new Menu();
        }
    }
}
