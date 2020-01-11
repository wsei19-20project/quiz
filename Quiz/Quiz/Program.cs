using quizLib;
using System;
using System.Net;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
    
            string apiUrl = "https://opentdb.com/api.php?amount=1&type=multiple";

            var client = new WebClient();
            var content = client.DownloadString(apiUrl);

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Questions>(content);
            Console.WriteLine(obj.results[0].question);

            QuizLib1.quizInfo();

        }

    }

    public class Results
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public string[] incorrect_answer;
    }

    public class Questions
    {
        public int response_code;
        public Results[] results;

    }
}