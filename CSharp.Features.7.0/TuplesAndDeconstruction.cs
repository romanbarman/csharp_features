namespace CSharp.Features._7._0
{
    internal class TuplesAndDeconstruction
    {
        public void Run()
        {
            var tuple1 = Create1();
            Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");

            var tuple2 = Create2();
            Console.WriteLine($"{tuple2.number} {tuple2.word}");

            var tuple3 = Create3();
            Console.WriteLine($"{tuple3.number} {tuple3.word}");

            (var number1, var word1) = Create1();
            Console.WriteLine($"{number1}, {word1}");

            var (number2, word2) = Create2();
            Console.WriteLine($"{number2}, {word2}");

            (number2, word2) = Create3();
            Console.WriteLine($"{number2}, {word2}");
        }

        private (int, string) Create1()
        {
            return (25, "Hello");
        }

        private (int number, string word) Create2()
        {
            return (26, "Hi");
        }

        private (int number, string word) Create3()
        {
            var number = 27;
            var word = "Good";
            return (number: number, word: word);
        }
    }
}
