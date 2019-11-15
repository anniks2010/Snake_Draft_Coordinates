using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeDraft
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point (int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.SetWindowSize(25, 25); ////sellega saab piirata konsooli akna suurust
            Console.SetBufferSize(25, 25); ////sellega saab piirata, et ei tekiks konsooli aknasse suurenud scrolle.*/

            /*Console.BackgroundColor = ConsoleColor.White; ////Koos Clear () tuleb kasutada ning saab konsooli tagatausta värvida.
            Console.Clear();*/

            ///Declare point coordinates
            /*int x1 = 10;
            int y1 = 10;
            char symbol1 = '*';
            Draw(p1.x1, p1.y1, p1.symbol1); selle asemel tegime klassi ning deklareerime objektina uued koordinaadid. p1 on lisatud siis kui allolev funktsioon ei ole klassi meetoditesse tõstetud.*/

            /*Console.SetCursorPosition(x1, y1); ///sellega on kursoor seal, kus ma olen koordinaatidega tal käskinud olla.
            ////Console.ForegroundColor = ConsoleColor.Blue; ////täpi värvimine
            Console.Write(symbol1); ///punkti joonistamine, märkimine*/

            /*int x2 = 11;
            int y2 = 10;

            ////string symbol2 = "-----------"; saab ka nii teha stringina, siis saab mitu sümbolit lisada korraga 
            char symbol2 = '#';
            Draw(p2.x2, p2.y2, p2.symbol2); selle asemel tegime klassi ning deklareerime objektina uued koordinaadid. p2 on lisatud siis kui allolev funktsioon ei ole klassi meetoditesse tõstetud.*/

            /*Console.SetCursorPosition(x2, y2);
            
            Console.Write(symbol2);*/

            Point p1 = new Point(10, 10, '*');
            p1.Draw();

            Point p2 = new Point(10, 11, '*');
            p2.Draw();


            Console.ReadLine();
        }
        /*public static void Draw(int x, int y, char symbol) ////selle funktsiooni tõstsime ülesse klassi 'Point' meetodiks.
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);

        }*/
    }
}
