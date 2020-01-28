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
    /// Interaction logic for ScoreScreen.xaml
    /// </summary>
    public partial class ScoreScreen : Page
    {
        public ScoreScreen(string endscore)
        {
            InitializeComponent();
            if (endscore == "win")
            {
                this.fail.Visibility = Visibility.Hidden;
                this.success.Visibility = Visibility.Visible;
                this.textResult.Text = "YOU WIN!";
            }
            else
            {
                this.success.Visibility = Visibility.Hidden;
                this.fail.Visibility = Visibility.Visible;
                this.textResult.Text = "YOU LOSE!";
            }

        }

        private void backToMenu(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            window.Content = new Menu();
        }
    }
}
