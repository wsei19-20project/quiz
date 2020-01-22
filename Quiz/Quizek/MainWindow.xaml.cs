﻿using System;
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
    public partial class MainWindow : Window
    {
        private void BtnClickGame(object sender, RoutedEventArgs e)
        {
            Main.Content = new Game();
        }

        private void BtnClickSettings(object sender, RoutedEventArgs e)
        {
            Main.Content = new Settings();
        }

        private void BtnClickMenu(object sender, RoutedEventArgs e)
        {
            Main.Content = new Menu();
        }

        private void BtnClickMain(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainWindow();
        }

    }
}
