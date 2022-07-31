namespace CSharp.Features._8._0
{
    class AsynchronousStreams
    {
        public async Task Run()
        {
            await foreach (var item in Get())
            {
                Console.WriteLine(item);
            }
        }

        public static async IAsyncEnumerable<int> Get()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
