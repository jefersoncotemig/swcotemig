using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientWebTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var id = 10;

                Console.ReadLine();
                var expectresult = client.GetStringAsync($"http://localhost:8080/v1/persons");
                var result = expectresult.Result;
                Console.WriteLine(result);
                Console.ReadLine();
            }

        }
    }
}
