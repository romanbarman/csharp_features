namespace CSharp.Features._8._0
{
    class TuplePatterns
    {
        public void Run()
        {
            Console.WriteLine(GetNumber(2, "Akexander"));
        }

        public static int GetNumber(int id, string name) => (id, name) switch
        {
            (1, "Kiril") => 0,
            (2, "Alexander") => 1,
            _ => 3
        };
    }
}
