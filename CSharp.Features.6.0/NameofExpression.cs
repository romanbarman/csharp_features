namespace CSharp.Features._6._0
{
    class NameofExpression
    {
        public void Run(string line)
        {
            if (line == null)
                throw new ArgumentNullException(nameof(line));
        }
    }
}
