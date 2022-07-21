namespace CSharp.Features._7._1
{
    class GenericPatternMatching
    {
        public void Run()
        {
            Console.WriteLine(Get(new[] { 1 }));
        }

        public int Get<T>(T obj)
        {
            switch (obj)
            {
                case Array _:
                    return 1;
                case string str:
                    return str.Length;
                case null:
                    throw new Exception("NULL");
                default:
                    return 0;
            }
        }
    }
}
