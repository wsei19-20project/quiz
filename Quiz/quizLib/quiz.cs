using System;
using System.Net;

namespace quizLib
{
    /// <summary>
    /// The main Quiz class.
    /// Contains all methods for performing basic functions on the api.
    /// </summary>
    public class QuizLib1
    {
        /// <summary>
        /// Contatins all question informations
        /// </summary>
        public class Results
        {
            public string category;
            public string type;
            public string difficulty;
            public string question;
            public string correct_answer;
            public string[] incorrect_answers;
        }

        /// <summary>
        /// Conatins Results and response code
        /// </summary>
        public class Questions
        {
            public int response_code;
            public Results[] results;

        }

        /// <summary>
        /// Get the question from the Api
        /// </summary>
        /// <param name="category">string informs category of the question.</param>
        /// <param name="difficulty">string informs difficulty of the question.</param>
        /// <returns>
        /// object question
        /// </returns>
        public static Questions generateQuestion(string category, string difficulty)
        {
            string apiUrl = $"https://opentdb.com/api.php?amount=1&category={category}&difficulty={difficulty}&type=multiple";
            var client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            var content = client.DownloadString(apiUrl);
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Questions>(content);
            
            return obj;
        }

        /// <summary>
        /// Get the question from the question object
        /// </summary>
        public static string getQuestion(Questions q)
        {
            return q.results[0].question;
        }

        /// <summary>
        /// Get the correct answer from the question object
        /// </summary>
        public static string getCorrectAnswer(Questions q)
        {
            return q.results[0].correct_answer;
        }

        /// <summary>
        /// Get all(right and wrongs) answer from the question object
        /// </summary>
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
