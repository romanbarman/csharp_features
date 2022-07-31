namespace CSharp.Features._8._0
{
    class UsingDeclarations
    {
        public void Run()
        {
            using var file = new StreamWriter("Text.txt");
            for (int i = 0; i < 100; i++)
            {
                file.WriteLine(i);
            }
        }
    }
}
