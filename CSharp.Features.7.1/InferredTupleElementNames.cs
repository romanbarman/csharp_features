namespace CSharp.Features._7._1
{
    class InferredTupleElementNames
    {
        public void Run()
        {
            var age = 25;
            var word = "Hello";
            var tuple = (age, word);

            Console.WriteLine($"{tuple.age} {tuple.word}");
        }
    }
}
