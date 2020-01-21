using System;
using System.Net;

namespace quizLib
{
    public class QuizLib1
    {
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

        public static void quizInfo()
        {
            Console.WriteLine("Quiz Liblary");
        }

        public static Questions generateQuestion(string category, string difficulty)
        {
            string apiUrl = $"https://opentdb.com/api.php?amount=1&category={category}&difficulty={difficulty}&type=multiple";
            var client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            var content = client.DownloadString(apiUrl);

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Questions>(content);
            
            return obj;
        }

        public static string getQuestion(Questions q)
        {
            return q.results[0].question;
        }

        public static string getCorrectAnswer(Questions q)
        {
            return q.results[0].correct_answer;
        }

        public static string[] getAnswers(Questions q)
        {
            string[] answersArray = new string[4] {q.results[0].correct_answer, q.results[0].incorrect_answers[0], q.results[0].incorrect_answers[1], q.results[0].incorrect_answers[2]};
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

            return answersArray;
        }

    }
}
