using System;
using System.Collections.Generic;
using System.Text;

namespace quizLib
{
    public class Score
    {
        public int Points=0;

        public Score()
        {
            Points = 0;
        }

        public void addPoint()
        {
            Points++;
        }
        public void clearPoints()
        {
            Points = 0;
        }
        public int getPoints()
        {
            return Points;
        }
    }
}
