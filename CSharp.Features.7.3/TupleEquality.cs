namespace CSharp.Features._7._3
{
    class TupleEquality
    {
        public void Run()
        {
            var t1 = (25, "Hi");
            var t2 = (25, "Yes");

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
        }
    }
}
