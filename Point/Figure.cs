using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Figure
    {
        protected List<Point> pointList = new List<Point>(); ///protected tähendab seda, et ainult tema alamklassid saavad seda listi kasutada. Private, siis saab ainult see klass saab kasutada.
        public void DrawFigure()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}

