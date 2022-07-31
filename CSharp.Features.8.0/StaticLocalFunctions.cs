namespace CSharp.Features._8._0
{
    class StaticLocalFunctions
    {
        public void Run()
        {
            var x = 5;
            var y = 10;

            Console.WriteLine(Add(x, y));

            static int Add(int right, int left)
            {
                return right + left;
            }
        }
    }
}
