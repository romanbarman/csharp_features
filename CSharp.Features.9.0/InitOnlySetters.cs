namespace CSharp.Features._9._0
{
    class InitOnlySetters
    {
        public void Run()
        {
            var test = new Test { Id = 1 };
        }
    }

    class Test
    {
        public int Id { get; init; }
    }
}
