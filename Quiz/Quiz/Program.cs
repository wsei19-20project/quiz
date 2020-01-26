using quizLib;
using System;
using System.Net;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizMenager q1 = new QuizMenager();
            //var questions = q1.getQuestion();
            //q1.playQuiz(questions);
            var q = QuizLib1.generateQuestion("","");

            string[] answersArray = new string[4] { q.results[0].correct_answer, q.results[0].incorrect_answers[0], q.results[0].incorrect_answers[1], q.results[0].incorrect_answers[2] };
            int index;
            string tmp;
            Random rand = new Random();

            for (int i = 0; i < answersArray.Length; i++)
            {
                index = rand.Next(answersArray.Length);

                tmp = answersArray[i];
                answersArray[i] = answersArray[index];
                answersArray[index] = tmp;
            }

            foreach (var a in answersArray)
                Console.WriteLine(a);

            Console.WriteLine("C: " + q.results[0].correct_answer);
            //QuizLib1.quizInfo();

        }

    }
    public class QuizMenager
    {
        
        public void playQuiz(Questions q)
        {
            var result = q.results[0];

            Console.WriteLine("Question: " + result.question);

            Console.WriteLine("C: " + result.correct_answer);
            for (int i = 0; i < result.incorrect_answers.Length; i++)
            {
                Console.WriteLine("F: " + result.incorrect_answers[i]);
            }
        }
    }

    public class Results
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public string[] incorrect_answers;
    }

    public class Questions
    {
        public int response_code;
        public Results[] results;

    }
}