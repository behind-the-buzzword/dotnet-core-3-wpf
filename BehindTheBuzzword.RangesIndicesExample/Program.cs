using System;
using System.Linq;

namespace BehindTheBuzzword.RangesIndicesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                        // index from start    index from end
            "The",      // 0                   ^9
            "quick",    // 1                   ^8
            "brown",    // 2                   ^7
            "fox",      // 3                   ^6
            "jumped",   // 4                   ^5
            "over",     // 5                   ^4
            "the",      // 6                   ^3
            "lazy",     // 7                   ^2
            "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0


            // to get the last word traditional
            Console.WriteLine($"The last word is {words[words.Length - 1]} (traditional)");

            // to get the last word C# 8
            Console.WriteLine($"The last word is {words[^1]} (thanks C# 8!)");

            // to get the first 3 words of the array traditional
            var quickBrownFox = words.Take(4);
            Console.WriteLine($"The first 4 words are {string.Join(",", quickBrownFox)} (traditional)");

            // to get the first 3 words of the array C# 8
            // Note how index four does not include item 3 (for zero based). It only incluse item indices 0-2
            quickBrownFox = words[0..3];
            Console.WriteLine($"The first 4 words are {string.Join(",", quickBrownFox)} (thanks C# 8!)");

            var lazyDog = words[^2..^0];
            Console.WriteLine($"The subrange of lazy and dog are obtained using ^2..^0 - {string.Join(",", lazyDog)} (thanks C# 8!)");

            var allWords = words[..]; // contains "The" through "dog".
            Console.WriteLine($"The entire phrase is {string.Join(" ", allWords)}");
            var firstPhrase = words[..4]; // contains "The" through "fox"
            Console.WriteLine($"The first phrase is {string.Join(" ", firstPhrase)}");
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Console.WriteLine($"The last phrase is {string.Join(" ", lastPhrase)}");

            Console.ReadKey();

        }
    }
}
