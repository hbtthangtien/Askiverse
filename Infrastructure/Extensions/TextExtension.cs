using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class TextExtension
    {
        public static List<string> SplitChunks(string text, int chunkSize = 1000, int overlap = 200)
        {
            var words = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var chunks = new List<string>();
            for (int i = 0; i < words.Length; i += chunkSize - overlap)
            {
                int take = Math.Min(chunkSize, words.Length - i);
                var chunk = string.Join(" ", words.Skip(i).Take(take));
                chunks.Add(chunk);
                if (i + take >= words.Length) break;
            }
            return chunks;
        }
    }
}
