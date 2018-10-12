using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonGame.Application;
using PersonGame.Application.DTOs;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class PersonController : Controller
    {
        IPersonService _personService;
        IGameService _gameService;

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
            try
            {
                _personService.Insert(model.personDto);

                return RedirectToAction(nameof(Index));
            }
            catch( Exception ex)
            {
                return View();
            }
        }
    }
}