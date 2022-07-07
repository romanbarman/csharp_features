namespace CSharp.Features._6._0
{
    class ExpressionBodiedFunctionProperty
    {
        public void Run() => Console.WriteLine("Hello world!");

        public string Name { get; } = "Vlada";
        public int Age { get; } = 23;
        public string Info => Name + " " + Age;
    }
}
