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
using System.Media;
using System.ComponentModel;

namespace Quizek
{
    public partial class MainWindow : Window
    {
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            presskey.Visibility = Visibility.Hidden;
            Main.Content = new Menu();
        }

    }
}
