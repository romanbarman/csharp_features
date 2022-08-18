namespace CSharp.Features._10._0
{
    class NaturalTypeOfALambdaExpression
    {
        public void Run()
        {
            var parse = (string s) => int.Parse(s);
            var action = () => Console.WriteLine(parse);
        }
    }
}
