using Microsoft.AspNetCore.Mvc;
using PersonGame.Application;
using PersonGame.Application.DTOs;
using System.Collections.Generic;

namespace PersonGameWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/person
        [HttpGet]
        public IEnumerable<ViewPersonDto> Get()
        {
            return _personService.GetAll();
        }

        // POST: Person/Create
        [HttpPost]
        public void Create([FromBody] WritePersonDto model)
        {
            _personService.Insert(model);
        }

        // PUT: api/Game/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WritePersonDto model)
        {
            _personService.Update(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personService.Delete(id);
        }
    }
}