namespace CSharp.Features._10._0
{
    class RecordStructs
    {
        public void Run()
        {
            var point = new Point() { X = 10, Y = 20, Z = 30 };
        }
    }

    public record struct Point
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }
    }
}
