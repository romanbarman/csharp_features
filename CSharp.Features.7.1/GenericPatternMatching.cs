namespace CSharp.Features._7._1
{
    class GenericPatternMatching
    {
        public void Run()
        {
            Console.WriteLine(Get(new[] { 1 }));
        }

        public int Get<T>(T obj) => obj switch
        {
            Array _ => 1,
            string str => str.Length,
            null => throw new Exception("NULL"),
            _ => 0,
        };
    }
}
