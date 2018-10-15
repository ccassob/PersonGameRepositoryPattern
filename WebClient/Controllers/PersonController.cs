using Microsoft.AspNetCore.Mvc;
using PersonGame.Application;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class PersonController : Controller
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService, IGameService gameService)
        {
            _personService = personService;
        }

        // GET api/person
        [HttpGet]
        public IActionResult Index()
        {
            return View(_personService.GetAll());
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            var personViewModel = new PersonViewModel();

            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PersonViewModel model)
        {
            _personService.Insert(model.PersonDto);

            return RedirectToAction(nameof(Index));
        }
    }
}