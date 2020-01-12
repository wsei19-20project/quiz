﻿using quizLib;
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

namespace Quizek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string correctAnswer;
        public MainWindow()
        {
            InitializeComponent();
            var quiz = QuizLib1.generateQuestion();
            questionTxtBlock.Text = QuizLib1.getQuestion(quiz);
            correctAnswer = QuizLib1.getCorrectAnswer(quiz);
            ResultTxtBlock.Text = correctAnswer;

            string[] answers = QuizLib1.getAnswers(quiz);
            Answer1Btn.Content = answers[0];
            Answer2Btn.Content = answers[1];
            Answer3Btn.Content = answers[2];
            Answer4Btn.Content = answers[3];

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Answer1Btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Answer1Btn.Content == correctAnswer)
                ResultTxtBlock.Text = "Win";
            else
                ResultTxtBlock.Text = "Lose";

        }

        private void Answer2Btn_Click_1(object sender, RoutedEventArgs e)
        {
            if ((string)Answer2Btn.Content == correctAnswer)
                ResultTxtBlock.Text = "Win";
            else
                ResultTxtBlock.Text = "Lose";
        }

        private void Answer3Btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Answer3Btn.Content == correctAnswer)
                ResultTxtBlock.Text = "Win";
            else
                ResultTxtBlock.Text = "Lose";
        }

        private void Answer4Btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Answer4Btn.Content == correctAnswer)
                ResultTxtBlock.Text = "Win";
            else
                ResultTxtBlock.Text = "Lose";
        }
    }
}
