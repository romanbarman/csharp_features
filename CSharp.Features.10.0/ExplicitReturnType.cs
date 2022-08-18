namespace CSharp.Features._10._0
{
    class ExplicitReturnType
    {
        public void Run()
        {
            var choose = object (bool b) => b ? 1 : "two";
        }
    }
}
