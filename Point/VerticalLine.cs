using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class VerticalLine : Figure
    {
        ///public List<Point> pointList = new List<Point>();

        public VerticalLine(int yUp, int yDown, int x, char symbol)
        {

            for(int i = yUp; i<= yDown; i++)
            {
                Point newPoint = new Point(x, i, symbol);
                pointList.Add(newPoint);
            }
        }
        /*public void DrawVerticalLine()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }
        }*/
    }
}
