namespace CSharp.Features._7._0
{
    class OutVariables
    {
        public void Run()
        {
            Initialize(out var x, out var y);
            Console.WriteLine($"x = {x}, y = {y}");
        }

        private void Initialize(out int x, out int y)
        {
            x = 0;
            y = 0;
        }
    }
}
