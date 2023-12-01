using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace StraightOutOfTheWizard.Models
{
    internal class Class1
    {
        public Class1()
        {
            var dict = new Dictionary<string, string>();

            var url = "http://webcode.me";

            using var client = new HttpClient();

            var msg = new HttpRequestMessage(HttpMethod.Get, url);
            msg.Headers.Add("User-Agent", "C# Program");
            var res = await client.SendAsync(msg);

            var content = await res.Content.ReadAsStringAsync();

            Console.WriteLine(content);

            dict.ContainsKey()
        }

    }
}
