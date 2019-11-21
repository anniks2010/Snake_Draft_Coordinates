using System;

namespace Point
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        public Point(Point _p)
        {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Clear()
        {
            symbol = ' ';
            Draw();
        }
        public void MovePoint(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN) ////kui kasutada enum, siis tuleks lõpuni else if kasutada mitte else ainult lõpuks, kuna muidu võib ta reageerida igale klahvile.
            {
                y = y + offset;
            }

        }
    }
}
