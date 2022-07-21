namespace CSharp.Features._8._0
{
    class ReadonlyMembers
    {
        public void Run()
        {
            var test = new TestStruct(5);
            Console.WriteLine(test);
        }
    }

    struct TestStruct
    {
        public int Value { get; set; }
        public readonly int Square => Value * Value;
        public TestStruct(int value)
        {
            Value = value;
        }

        public readonly override string ToString()
        {
            return Value.ToString() + Square.ToString();
        }
    }
}
