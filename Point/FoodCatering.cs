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

        public FoodCatering (int _mapWidth, int _mapHeight, char _symbol)
        {
            MapWidth = _mapWidth;
            MapHeight = _mapHeight;
            Symbol = _symbol;
        }
        public Point CaterFood()
        {
            int x = rnd.Next(2, MapWidth - 2);
            int y = rnd.Next(2, MapHeight - 2);
            return new Point(x, y, Symbol);
        }
    }
}
