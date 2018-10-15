using Microsoft.AspNetCore.Mvc;
using PersonGame.Application;
using PersonGame.Application.DTOs;

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
        public IActionResult Index()
        {
            return Ok(_personService.GetAll());
        }

        // POST: Person/Create
        [HttpPost]
        public IActionResult Create(CreatePersonDto model)
        {
            _personService.Insert(model);

            return Ok("Creado correctamente");
        }

        // POST: Person/Edit/5
        [HttpPut]
        public IActionResult Edit(PersonViewDto model)
        {
            _personService.Update(model);

            return Ok("Actualizado correctamente");
        }

        // POST: Person/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _personService.Delete(id);

            return Ok("Eliminado correctamente");
        }
    }
}