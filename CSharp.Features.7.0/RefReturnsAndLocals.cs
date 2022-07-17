namespace CSharp.Features._7._0
{
    class RefReturnsAndLocals
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3 };
            ref var result = ref GetByIndex(1, array);
            result = 100;
            Console.WriteLine(array[1]);//prints 100
        }

        private ref int GetByIndex(int index, int[] array)
        {
            return ref array[index];
        }
    }
}
