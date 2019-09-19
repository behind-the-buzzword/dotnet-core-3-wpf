using System.Collections.Generic;

namespace BehindTheBuzzword.Web
{
    public interface IWordGeneratorService
    {
        IAsyncEnumerable<Item> GetWordsAsync(int numberOfWords);
    }
}