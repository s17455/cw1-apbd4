using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();
                Console.WriteLine(html);
            }
            Console.WriteLine("Koniec!");
        }
    }
}
