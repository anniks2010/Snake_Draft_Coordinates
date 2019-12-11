using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class FoodCatering
    {
        int MapWidth;
        int MapHeight;
        char Symbol;
        

        Random rnd = new Random();
        Random rnd2 = new Random();

        public FoodCatering (int _mapWidth, int _mapHeight, char _symbol)
        {
            MapWidth = _mapWidth;
            MapHeight = _mapHeight;
            Symbol = _symbol;
            
        }
        public Point CaterFood()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int x = rnd.Next(2, MapWidth - 2);
            int y = rnd.Next(2, MapHeight - 2);
            return new Point(x, y, Symbol);
           
        }
        public Point CaterFood2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int x = rnd2.Next(2, MapWidth - 2);
            int y = rnd2.Next(2, MapHeight - 2);
            return new Point(x, y, Symbol);

        }

    }
}
