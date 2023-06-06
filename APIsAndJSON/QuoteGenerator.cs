using System;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
	public class QuoteGenerator
	{
		public static void KanyeQoute()
		{
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            
            

                Console.WriteLine($"");
                Console.WriteLine("--------------------------");
                Console.WriteLine($"Kanye:'{kanyeResponse}'");
                


            

        }

        public static void RonQoute()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQoute = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            
            

                Console.WriteLine($"");
                Console.WriteLine($"Ron:'{ronResponse}'");
                Console.WriteLine("--------------------------");
              

            

        }


	}
}

