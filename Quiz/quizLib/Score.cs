using System;
using System.Collections.Generic;
using System.Text;

namespace quizLib
{
    /// <summary>
    /// Contains all methods for Score(lifes)
    /// </summary>
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
