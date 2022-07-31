namespace CSharp.Features._8._0
{
    class NullableReferenceTypes
    {
        public void Run()
        {
            var test = new Test();
            Console.WriteLine(test.Id);
        }
    }

    class Test
    {
        public string? Id { get; set; }
    }
}
