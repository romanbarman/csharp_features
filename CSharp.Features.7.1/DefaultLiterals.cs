namespace CSharp.Features._7._1
{
    class DefaultLiterals
    {
        public async Task Run()
        {
            var result = await Get();

            var cancelToken = new CancellationTokenSource();
            result = await Get(cancelToken.Token);
        }

        private Task<int> Get(CancellationToken token = default)
        {
            return Task.Run(() =>
            {
                token.ThrowIfCancellationRequested();
                return 10;
            });
        }
    }
}
