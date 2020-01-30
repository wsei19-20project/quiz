using Microsoft.VisualStudio.TestTools.UnitTesting;
using quizLib;

namespace UnitTestQuiz
{
    [TestClass]
    public class QuizTests
    {
        [TestMethod]
        public void QuizMethod1()
        {
            string diff = "easy";
            string cat = "15";

            var quiz = QuizLib1.generateQuestion(cat, diff);

            Assert.AreEqual(quiz.response_code, 0);
            
        }
    }
}
