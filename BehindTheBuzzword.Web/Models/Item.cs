using System;
using System.Collections.Generic;
using System.Text;

namespace BehindTheBuzzword.Web
{
    public class Item
    {
        string[] words = new string[]
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
   };


        public string Word;

        public Item(int v)
        {
            var random = new Random();
            var item = random.Next(words.Length);
            Word = words[item];
        }
    }
}
