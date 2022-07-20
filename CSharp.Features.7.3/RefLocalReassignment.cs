namespace CSharp.Features._7._3
{
    class RefLocalReassignment
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3 };
            ref var element = ref array[0];
            element = ref array[1];

            Console.WriteLine(element);
        }
    }
}
