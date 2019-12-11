using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Point
{
    class Score
    {

        int score = 0;

        public int GetScore(int score,int xOffset,int yOffset)
        {
            return score;
        }
        public void AddPoint()
        {

            
           
            int xOffset = 26;
            int yOffset = 0;

            score++;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            GetScore(score, xOffset, yOffset++);

        }
        public void ResetScore()
        {
            score = 0;
        }
            
        
        
         
        
    }
}
