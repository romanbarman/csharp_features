namespace CSharp.Features._6._0
{
    class NullPropagation
    {
        public void Run(string line)
        {
            Console.WriteLine(line?.Length ?? 0);
        }
    }
}
