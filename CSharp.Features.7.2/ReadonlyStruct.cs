namespace CSharp.Features._7._2
{
    class ReadonlyStruct
    {
        public void Run()
        {
            var test = new TestStruct(10);
            Show(test);
        }

        private void Show(in TestStruct testStruct)
        {
            Console.WriteLine(testStruct);
        }
    }

    readonly struct TestStruct
    {
        private readonly int x;

        public TestStruct(int x)
        {
            this.x = x;
        }
    }
}
