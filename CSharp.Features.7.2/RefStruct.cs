
namespace CSharp.Features._7._2
{
    class RefStruct
    {
        public void Run()
        {
            var test = new Test(10);
        }
    }

    ref struct Test
    {
        private int x;
        public Test(int x)
        {
            this.x = x;
        }
    }
}
