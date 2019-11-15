using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(10, 10, '*');
            p1.Draw();

            Point p2 = new Point(10, 11, '*');
            p2.Draw();

            Point p3 = new Point(10, 12, '*');
            p3.Draw();

            Point p4 = new Point(10, 13, '*');
            p4.Draw();

            Point p5 = new Point(10, 14, '*');
            p5.Draw();

            Point p6 = new Point(11, 10, '*');
            p6.Draw();

            Point p7 = new Point(12, 10, '*');
            p7.Draw();

            Point p8 = new Point(13, 10, '*');
            p8.Draw();

            Point p9 = new Point(14, 10, '*');
            p9.Draw(); Esimmene võimalus*/

            /*for (int i = 5; i < 10; i++)
            {
                Point newPoint = new Point(i, 5, '*');
                newPoint.Draw();
                Point newPoint2 = new Point(5, i, '*');
                newPoint2.Draw();
                
            }Teine võimalus*/

            /// Kolmas võimalus, luua eraldi klass horisontaaljoone jaoks:

            Console.BackgroundColor = ConsoleColor.Yellow; ////Koos Clear () tuleb kasutada ning saab konsooli tagatausta värvida.
            Console.Clear(); 

            Console.SetWindowSize(26, 26); ////sellega saab piirata konsooli akna suurust
            Console.SetBufferSize(26, 26); ///sellega scrolli maha, ehk piirata konsooli akna tegelikku mahutavust

            Console.ForegroundColor = ConsoleColor.Black;

            HorizontalLine topLine = new HorizontalLine(0, 24, 0, '*');
            topLine.DrawHorizontalLine();

            VerticalLine leftVerticalLIne = new VerticalLine(0, 24, 0, '*');
            leftVerticalLIne.DrawVerticalLine();

            HorizontalLine buttonLine = new HorizontalLine(1, 24, 24, '*');
            buttonLine.DrawHorizontalLine();

            VerticalLine rightVerticalLIne = new VerticalLine(0, 24, 24, '*');
            rightVerticalLIne.DrawVerticalLine();


            Console.ReadLine();
        }
    }
}
