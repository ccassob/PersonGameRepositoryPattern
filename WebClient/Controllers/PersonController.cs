using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonGame.Application;
using PersonGame.Application.DTOs;

namespace WebClient.Controllers
{
    public class PersonController : Controller
    {
        IPersonService _personService;

        public PersonController(IPersonService personService)
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
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreatePersonDto model)
        {
            try
            {
                _personService.Insert(model);

                return RedirectToAction(nameof(Index));
            }
            catch( Exception ex)
            {
                return View();
            }
        }
    }
}