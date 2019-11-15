using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class HorizontalLine
    {
        public List<Point> pointList = new List<Point>();

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            for (int i= xLeft; i <= xRight; i++) ////hakkab tööle xLeft ning lõppeb siis kui jõuab xRight
            {
                Point newPoint = new Point(i, y, symbol);
                pointList.Add(newPoint);
            }
        }
        public void DrawHorizontalLine()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }
        }


    }
}
