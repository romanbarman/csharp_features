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

        public int SwitchStatementPatternMatching(object obj) 
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

        public int SwitchStatementWhenConditionPatternMatching(object obj)
        {
            switch (obj)
            {
                case Array a when a.IsReadOnly == true:
                    return 1;
                case Array a when a.Length == 10:
                    return 10;
                case null:
                    throw new Exception("NULL");
                default:
                    return 0;
            }
        }

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
