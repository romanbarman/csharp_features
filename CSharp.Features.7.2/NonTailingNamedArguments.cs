namespace CSharp.Features._7._2
{
    class NonTailingNamedArguments
    {

        public void Run()
        {
            Test(10, bold: true, true);
        }

        private void Test(int number, bool bold = false, bool centered = false)
        {

        }
    }
}
