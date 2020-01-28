using quizLib;
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

    public partial class Game : Page
    {
        public string category;
        public string difficulty;
        public QuestionNo questionNumber = new QuestionNo();
        public Score points = new Score();
        public string correctAnswer;
        public int currentQuestion;
        public Game(string Category, string Difficulty)
        {
            this.category = Category;
            this.difficulty = Difficulty;
            InitializeComponent();
            startGame();
        }

        public void startGame()
        {
            var quiz = QuizLib1.generateQuestion(category, difficulty);
            questionTxtBlock.Text = QuizLib1.getQuestion(quiz);
            correctAnswer = QuizLib1.getCorrectAnswer(quiz); 

            currentQuestion = questionNumber.getQuestionNo();       
            questionNumber.questionIncrease();
            
            string[] answers = QuizLib1.getAnswers(quiz);
            Answer1Btn.Content = answers[0];
            Answer2Btn.Content = answers[1];
            Answer3Btn.Content = answers[2];
            Answer4Btn.Content = answers[3];

            DeathCounter();
        }

        private void Answer1Btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Answer1Btn.Content != correctAnswer)
            {
                points.decreasePoint();
                
            }

            if (currentQuestion < 9)
                startGame();
            else
                EndGame();

        }

        private void Answer2Btn_Click_1(object sender, RoutedEventArgs e)
        {
            if ((string)Answer2Btn.Content != correctAnswer)
            {
                points.decreasePoint();
            }

            if (currentQuestion < 9)
                startGame();
            else
                EndGame();

        }

        private void Answer3Btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Answer3Btn.Content != correctAnswer)
            {
                points.decreasePoint();
                
            }

            if (currentQuestion < 9)
                startGame();
            else
                EndGame();

        }

        private void Answer4Btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Answer4Btn.Content != correctAnswer)
            {
                points.decreasePoint();
                
            }

            if (currentQuestion < 9)
                startGame();
            else
                EndGame();
        }

        private void backToMenu(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            window.Content = new Menu();
        }

        public void DeathCounter()
        {
            if (points.getPoints() == 2)
            {
                this.Life3.Visibility = Visibility.Hidden;
            }
            else if (points.getPoints() == 1)
            {
                this.Life2.Visibility = Visibility.Hidden;
            }
            else if (points.getPoints() == 0)
            {
                this.Life3.Visibility = Visibility.Visible;
                this.Life2.Visibility = Visibility.Visible;
                EndGame();
            }
        }

        private void EndGame()
        {
            if(points.getPoints() > 0)
            {
                Window window = Window.GetWindow(this);

                window.Content = new ScoreScreen("win");
                questionNumber.questionClear();
                points.clearPoints();
            }
            else
            {
                Window window = Window.GetWindow(this);

                window.Content = new ScoreScreen("lose");
                questionNumber.questionClear();

            }
        }
    }
}
