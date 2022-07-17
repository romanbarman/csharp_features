namespace CSharp.Features._7._0
{
    class LocalFunctions
    {
        public void Run()
        {
            Console.WriteLine(Sum(10, 15));

            int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
}
