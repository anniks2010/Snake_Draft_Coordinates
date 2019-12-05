using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Point
{
    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    class Snake : Figure
    {
        public Direction Direction;
        

        public Snake(Point tail, int lenght, Direction _direction) ///alakriips tähendab, et ma kasutan seda objekti loomiseks
        {
            ////Console.ForegroundColor = ConsoleColor.Green;
            Direction = _direction;

            for(int i =0; i< lenght; i++)
            {
                Point newPoint = new Point(tail);
                newPoint.MovePoint(i, Direction);
                pointList.Add(newPoint);
                
            }
           
        }
        public void MoveSnake()
        {
            Point tail = pointList.First(); ///see on esimene element, punkt ehk element nr 0
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);
            tail.Clear();
            head.Draw();

        }
        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.MovePoint(1, Direction);
            return nextPoint;
        }  
        public void ReadUserKey(ConsoleKey key)
        {
           if (key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;
            }
           else if (key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;
            }
           else if (key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
           else if (key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;
            }
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food)) ////kui see on true, siis lisab selle pointlisti sisse sele punkti.
            {
                food.symbol = head.symbol; ///kui seda mitte panna, siis ta lisaks toidu sümboli ussi pikkusesse.
                pointList.Add(food);
                return true; ////kui on ära söönud, siis on true
            }
            else
            {
                return false; ///kui ei ole ära söönud, siis on false.
            }
        }
    }
}
