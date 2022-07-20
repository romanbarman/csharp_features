namespace CSharp.Features._7._2
{
    class InModifierOnParameters
    {
        public void Run()
        {
            Console.WriteLine(Increase(5));
        }

        private int Increase(in int a)
        {
            return a + 1;
        }
    }
}
