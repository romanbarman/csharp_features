namespace CSharp.Features._7._2
{
    class RefReadonlyModifierOnMethodRreturnsAndLocals
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3 };
            ref readonly var result = ref GetByIndex(1, array);
            Console.WriteLine(array[1]);
        }

        private ref readonly int GetByIndex(int index, int[] array)
        {
            return ref array[index];
        }
    }
}
