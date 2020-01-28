using System;
using System.Collections.Generic;
using System.Text;

namespace quizLib
{
    public class QuestionNo
    {
        public int CurrentQuestion = 0;

        public QuestionNo()
        {
            CurrentQuestion = 0;
        }

        public void questionIncrease()
        {
            CurrentQuestion++;
        }
        public void questionClear()
        {
            CurrentQuestion = 0;
        }
        public int getQuestionNo()
        {
            return CurrentQuestion;
        }
    }
}