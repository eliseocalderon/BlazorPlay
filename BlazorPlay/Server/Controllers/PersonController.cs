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
        public Task<IEnumerable<Person>> GetPeople()
        {
            var result = new List<Person>
            {
                new Person {FirstName = "Tim", LastName="Corey", AccountBalance=19.45M},
                new Person {FirstName = "Mary", LastName="Jones", AccountBalance=105.87M},
                new Person {FirstName = "John", LastName="Smith", AccountBalance=115.32M}
            };
            return Task.FromResult(result as IEnumerable<Person>);
        }

        [HttpPost]
        public async Task Post(Person person)
        {

        }
    }
}