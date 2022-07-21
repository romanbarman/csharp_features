namespace CSharp.Features._8._0
{
    class DefaultInterfaceMethods
    {
        public void Run()
        {
            IWrite<int> write = new Write();
            write.Write(10);
        }
    }

    interface IWrite<T>
    {
        void Write(T value)
        {
            Console.WriteLine(value);
        }
    }

    class Write : IWrite<int>
    {

    }
}
