using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using PersonGame.Domain.Interface;
using System;
using System.Collections.Generic;

namespace PersonGame.Application
{
    public class GameService : IGameService
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repository;

        public GameService(IMapper mapper, IRepository gameRepository)
        {
            _mapper = mapper;
            _repository = gameRepository;
        }

        public List<GameViewDto> GetAll()
        {
            var result = _repository.GetAll<Person>();
            return _mapper.Map<List<GameViewDto>>(_repository.GetAll<Game>());
        }

        public void Insert(WriteGameDto model)
        {
            var game = new Game(model.Name, model.Genre, model.Rating);
            _repository.Add(game);
        }

        public void Update(int id, WriteGameDto model)
        {
            var game = _repository.GetById<Game>(id);

            if (game == null)
            {
                throw new Exception("El juego no existe");
            }

            game = _mapper.Map<Game>(model);
            _repository.Update(game);
        }


        public void Delete(int id)
        {
            var game = _repository.GetById<Game>(id);
            if (game == null)
            {
                throw new ArgumentNullException("No fue encontrado");
            }

            _repository.Delete(game);
        }
    }
}