using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

            Console.BackgroundColor = ConsoleColor.White; ////Koos Clear () tuleb kasutada ning saab konsooli tagatausta värvida.
            Console.Clear(); 

            Console.SetWindowSize(26, 26); ////sellega saab piirata konsooli akna suurust
            Console.SetBufferSize(26, 26); ///sellega scrolli maha, ehk piirata konsooli akna tegelikku mahutavust

            Console.ForegroundColor = ConsoleColor.Black;

            Walls walls = new Walls(26, 26);
            walls.DrawWalls();

            ////Selle kohta tegime uue klassi Walls
            /*HorizontalLine topLine = new HorizontalLine(0, 24, 0, '*');
            //topLine.DrawHorizontalLine(); nüüd kasutame Figure klassi meetodit
            topLine.DrawFigure();

            VerticalLine leftVerticalLIne = new VerticalLine(0, 24, 0, '*');
            ///leftVerticalLIne.DrawVerticalLine(); nüüd kasutame Figure klassi meetodit
            leftVerticalLIne.DrawFigure();

            HorizontalLine buttonLine = new HorizontalLine(1, 24, 24, '*');
            ///buttonLine.DrawHorizontalLine(); nüüd kasutame Figure klassi meetodit
            buttonLine.DrawFigure();

            VerticalLine rightVerticalLIne = new VerticalLine(0, 24, 24, '*');
            ///rightVerticalLIne.DrawVerticalLine(); nüüd kasutame Figure klassi meetodit
            rightVerticalLIne.DrawFigure();*/

            Point tail = new Point(6, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.DrawFigure();

            FoodCatering foodCatering = new FoodCatering(26, 26, '$');
            Point food = foodCatering.CaterFood();
            food.Draw();
            
            /*while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        snake.Direction = Direction.LEFT;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        snake.Direction = Direction.RIGHT;
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        snake.Direction = Direction.UP;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        snake.Direction = Direction.DOWN;
                    }
                   
                }
                
                snake.MoveSnake();
                Thread.Sleep(300); ////See muudab ussi kiirust

            }See läks Snake klassi sisse meetodina readUserKey*/

            while (true)
            {
                if (walls.IsHitByFigure(snake))
                {
                    
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCatering.CaterFood();
                    food.Draw();
                }
                else
                {
                    snake.MoveSnake();
                }
                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReadUserKey(key.Key);
                }
                

            }

          
            WriteGameOver();



            Console.ReadLine();
        }
        public static void WriteGameOver()
        {
            Console.Clear();
            int xOffset = 8;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xOffset, yOffset++); ////kust ta peab alustama, ++ teeb ühe rea vahele ehk y kordinaat .
            ShowMessage("==========", xOffset, yOffset++);
            ShowMessage("GAME OVER!",xOffset,yOffset++);
            ShowMessage("==========", xOffset, yOffset++);
        }
        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        ///Viis uuendust lisada. takistused võiks lisada wall klassi, ning tekitada randomiga takistused. Skoori võiks näidata. Snake ära värvida.võib toitu värvida (toidu klassi tekib uus omadus värv)
    }
}
