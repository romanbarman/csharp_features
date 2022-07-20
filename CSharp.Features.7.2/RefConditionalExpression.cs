namespace CSharp.Features._7._2
{
    class RefConditionalExpression
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3 };
            ref var first = ref (array.Length < 2 ? ref array[0] : ref array[1]);
        }
    }
}
