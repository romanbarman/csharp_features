namespace CSharp.Features._7._0
{
    class PatternMatching
    {
        public void NullChecks()
        {
            int? i = 12;
            if (i is int number)
            {
                Console.WriteLine(number.ToString());
            }
            else
            {
                Console.WriteLine("NULL");
            }

            string message = "Hi";
            if (message is not null)
            {
                Console.WriteLine(message);
            }
        }

        public void DeclarationAndTypePatterns()
        {
            object word = "Hello";
            if (word is string message)
            {
                Console.Write(message);
            }
        }

        public int DeclarationAndTypePatterns(object obj) => obj switch
        {
            Array _ => 1,
            string str => str.Length,
            null => throw new Exception("NULL"),
            _ => 0,
        };

        public decimal ConstantPattern(int i) => i switch
        {
            1 => 10.1m,
            2 => 20.5m,
            _ => throw new Exception("No"),
        };

        public void VarPattern()
        {
            if (Create() is var result && result.Min() == 1)
            {
                Console.WriteLine("True");
            }
        }

        private IEnumerable<int> Create() => new int[] { 1, 2, 3 };
    }
}
