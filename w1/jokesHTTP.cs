using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyApplication
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();

        }         

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync(
                //"https://jsonplaceholder.typicode.com/todos");

                //return 3 random jokes with and replaces the name with "Mark Moore."
                "http://api.icndb.com/jokes/random/3?firstName=Mark&lastName=Moore");

                //returns joke number 15 and replaces the name with "John Doe."
                "http://api.icndb.com/jokes/15?firstName=John&lastName=Doe");


            Console.WriteLine(response);
        }



    }                       
}