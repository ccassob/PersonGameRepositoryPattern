using Microsoft.AspNetCore.Mvc;
using PersonGame.Application;
using PersonGame.Application.DTOs;
using System.Collections.Generic;

namespace PersonGameWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGameService _gameService;

        public GameController(IGameService services)
        {
            _gameService = services;
        }

        // GET: api/Game
        [HttpGet]
        public IEnumerable<GameViewDto> Get()
        {
            return _gameService.GetAll();
        }

        // GET: api/Game/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Game
        [HttpPost]
        public void Create([FromBody] WriteGameDto model)
        {
            _gameService.Insert(model);
        }

        // PUT: api/Game/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GameViewDto model)
        {
            _gameService.Update(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _gameService.Delete(id);
        }
    }
}