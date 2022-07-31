namespace CSharp.Features._8._0
{
    class IndicesAndRanges
    {
        public void Run()
        {
            var words = new string[]
            {
                "The",
                "quick",
                "brown",
                "fox",
                "jumped",
                "over",
                "the",
                "lazy",
                "dog"
            };

            Console.WriteLine($"The last word is {words[^1]}");

            var quickBrownFox = words[1..4];
            var lazyDog = words[^2..^0];
            var allWords = words[..];
            var firstPhrase = words[..4];
            var lastPhrase = words[6..];

            Range phrase = 1..4;
            var text = words[phrase];
        }
    }
}
