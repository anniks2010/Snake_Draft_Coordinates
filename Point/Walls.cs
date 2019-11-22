using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{

    class Walls
    {
        List<Figure> wallList;

        Random rnd = new Random();

        public Walls (int mapWidth, int mapHeight)
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            int begin = rnd.Next(2, mapHeight - 2);
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0,mapWidth-2,0, '#');
            HorizontalLine buttonLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '#');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '#');
            HorizontalLine takistus = new HorizontalLine(begin, x, y, '@');
            wallList.Add(topLine);
            wallList.Add(buttonLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
            wallList.Add(takistus);
        }
        public void DrawWalls()
        {
            foreach(Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }
        public bool IsHitByFigure(Figure figure)
        {
            foreach(Figure wall in wallList)
            {
                if (wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
