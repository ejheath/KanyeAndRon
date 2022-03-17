using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();
            */
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine($"Kanye: {quote.KanyeQuote()}");

                Console.WriteLine($"Ron Swanson: {quote.RonQuote()}");

            }
        }
    }
}
