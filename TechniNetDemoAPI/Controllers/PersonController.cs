using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechniNetDemoAPI.Models;

namespace TechniNetDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Person.liste);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            if (Person.liste.Where(x => x.Firstname == person.Firstname).Count() > 0)
            {
                return BadRequest("La personne existe déjà");
            }
            Person.Ajout(person);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Person p = Person.liste.Where(x => x.Id == id).First();
            
            return Ok(p);
        }

        [HttpGet("byname/{name}")]
        public IActionResult GetById([FromRoute] string name)
        {
            Person p = Person.liste.Where(x => x.Firstname == name).First();

            return Ok(p);
        }
    }
}
