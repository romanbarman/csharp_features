namespace CSharp.Features._8._0
{
    class SwitchExpressions
    {
        public void Run()
        {
            Console.WriteLine(Get("Hi"));
        }

        private int Get(object obj) => obj switch
        {
            string _ => 0,
            IEnumerable<int> _ => 1,
            _ => throw new ArgumentException("No")
        };
    }
}
