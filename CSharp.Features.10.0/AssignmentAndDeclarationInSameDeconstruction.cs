namespace CSharp.Features._10._0
{
    class AssignmentAndDeclarationInSameDeconstruction
    {
        public void Run()
        {
            var point = new Point1(10, 20);

            int x = 0;
            (x, int y) = point;
        }
    }

    class Point1
    {
        public int X { get; }
        public int Y { get; }

        public Point1(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
}
