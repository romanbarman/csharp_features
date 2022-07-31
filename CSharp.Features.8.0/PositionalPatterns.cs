namespace CSharp.Features._8._0
{
    class PositionalPatterns
    {
        public void Run()
        {
            Console.WriteLine(GetNumber(new Point(1, 2)));
        }

        public static int GetNumber(Point point) => point switch
        {
            (0, 0) => 0,
            var (x, y) when x > 0 && y > 0 => 1,
            var (x, y) when x > 0 && y < 0 => 2,
            _ => 3
        };
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
}
