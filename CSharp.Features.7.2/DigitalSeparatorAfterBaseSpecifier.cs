namespace CSharp.Features._7._2
{
    class DigitalSeparatorAfterBaseSpecifier
    {
        public void Run()
        {
            var hex = 0x_ff_ff_ff;
            var bin = 0b_0000_1111;
        }
    }
}
