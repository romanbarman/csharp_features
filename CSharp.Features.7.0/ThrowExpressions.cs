namespace CSharp.Features._7._0
{
    class ThrowExpressions
    {
        private string message;

        public ThrowExpressions(string message) => this.message = message ?? throw new ArgumentNullException(nameof(message));

        public string Get()
        {
            return this.message.Length > 5 ? this.message : throw new Exception("No");
        }

        public string Get(int i) => throw new NotImplementedException();
    }
}
