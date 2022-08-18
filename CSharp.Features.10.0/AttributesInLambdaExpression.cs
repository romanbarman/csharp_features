namespace CSharp.Features._10._0
{
    class AttributesInLambdaExpression
    {
        public void Run()
        {
            var sum = ([MyAttribute] int a, [MyAttribute] int b) => a + b;
            var inc = [return: MyAttribute] (int s) => s++;
        }
    }

    public class MyAttribute : Attribute
    {
    }
}
