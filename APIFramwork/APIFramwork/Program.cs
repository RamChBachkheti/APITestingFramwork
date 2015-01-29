using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APIFramwork
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                // TODO - Send HTTP requests
                //i3I2V24L24cT7wGA0CcdSPGn7m1
                client.BaseAddress = new Uri("https://api.shipbeat.com/");
                client.DefaultRequestHeaders.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
    HttpResponseMessage response = await client.GetAsync("areas/izab78s8aoD0c81o66Dgd2");
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine(response);
        /* Product product = await response.Content.ReadAsAsync>Product>();
         Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);*/
    }
    else
    {
        if (response.ReasonPhrase == "Unauthorized")
        {
            Console.WriteLine("Request is Unauthorized");
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Headers);
        }
       // if(response.StatusCode=40
    }




            }
        }
    }
}
