using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BehindTheBuzzword.AsyncStreams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        async Task WriteToFileAsync(string file)
        {
            await using (var fs = new FileStream(file, FileMode.CreateNew))
            await using (var sw = new StreamWriter(fs))
            {
                await sw.WriteAsync("Hello C# 8!");
            }
        }
    }
}
