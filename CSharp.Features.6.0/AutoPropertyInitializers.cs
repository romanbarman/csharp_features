namespace CSharp.Features._6._0
{
    class AutoPropertyInitializers
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public int Count { get; set; } = 0;
    }
}
