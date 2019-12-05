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

        public int GetScore(string text, int xOffset, int yOffset)
        {
            xOffset = 24;
            yOffset = 40;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            ///ShowMessage("Score:", xOffset, yOffset++);

            return score;
        }
        public void AddPoint()
        {
            score++;
        }
        public void ResetScore()
        {
            score = 0;
        }
            
        
        
         
        
    }
}
