using System;
using System.Collections.Generic;
using System.Text;

namespace quizLib
{
    public class Score
    {
        public int Points = 3;

        public Score()
        {
            Points = 3;
        }

        public void addPoint()
        {
            Points++;
        }
        public void decreasePoint()
        {
            Points--;
        }
        public void clearPoints()
        {
            Points = 3;
        }
        public int getPoints()
        {
            return Points;
        }
    }
}
