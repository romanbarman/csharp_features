namespace CSharp.Features._8._0
{
    class NullCoalescingAssignment
    {
        public void Run()
        {
            int? i = null;
            i ??= 15;
        }
    }
}
