using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPlay.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPlay.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public Task<IEnumerable<Person>> Get()
        {
            var result = new List<Person>
            {
                new Person {FirstName = "Tim", LastName="Corey", AccountBalance=19.45M},
                new Person {FirstName = "Mary", LastName="Jones", AccountBalance=105.87M},
                new Person {FirstName = "John", LastName="Smith", AccountBalance=115.32M}
            };

            var rnd = new Random(1000);
            for (int x = 1; x <= 100; x++)
            {
                result.Add(new Person { FirstName = GenerateName(5), LastName = GenerateName(8), AccountBalance = rnd.Next(1000) });
            }

            return Task.FromResult(result as IEnumerable<Person>);
        }

        [HttpPost]
        public void Post(Person person)
        {
            Console.WriteLine(person.FullName);
        }


        private static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
    }    
}