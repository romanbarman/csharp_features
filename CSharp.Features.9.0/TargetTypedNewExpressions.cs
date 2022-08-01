namespace CSharp.Features._9._0
{
    class TargetTypedNewExpressions
    {
        public void Run()
        {
            Dictionary<string, List<int>> field = new() {
                { "item1", new() { 1, 2, 3 } }
            };
        }
    }
}
