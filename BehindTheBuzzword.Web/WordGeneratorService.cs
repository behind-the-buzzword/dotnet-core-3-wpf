using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BehindTheBuzzword.Web
{
    public class WordGeneratorService : IWordGeneratorService
    {
        public async IAsyncEnumerable<Item> GetWordsAsync(int numberOfWords)
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(r.Next(100));
                yield return new Item(r.Next(100));
            }
        }
    }
}