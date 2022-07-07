namespace CSharp.Features._6._0
{
    class AwaitInCatchFinallyBlock
    {

        public async Task Run()
        {
            try
            {
                Method();
            }
            catch (Exception ex)
            {
                await HandleException(ex);
            }
            finally
            {
                await Finalize();
            }
        }

        private Task Finalize()
        {
            return Task.CompletedTask;
        }

        private void Method()
        {
            throw new NotImplementedException();
        }

        private Task HandleException(Exception exception)
        {
            return Task.CompletedTask;
        }
    }
}
