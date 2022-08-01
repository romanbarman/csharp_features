namespace CSharp.Features._9._0
{
    class PatternMatchingEnhancements
    {
        public void Run()
        {
            var str = "Hi";

            foreach (var ch in str)
            {
                if (ch is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'))
                {
                    Console.WriteLine(ch);
                }
            }
        }
    }
}
