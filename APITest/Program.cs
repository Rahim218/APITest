using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APITest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const string ApiUrl = "https://www.boredapi.com/api/activity";
            HttpClient client = new HttpClient();

           
            bool isContionue;
            do
            {
                var result = await client.GetStringAsync(ApiUrl);
               var BoredActivity =JsonConvert.DeserializeObject<Bored>(result);

                Console.WriteLine(BoredActivity.activity);

                Console.WriteLine("Davaam etmek isdiyirsize : true/false yazin");
                isContionue = Convert.ToBoolean(Console.ReadLine());
            } while (true);

        }
        class Bored
        {
            public string activity { get; set; }  
        }
    }
}
