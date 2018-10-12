using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using PersonGame.Domain.Interface;
using System.Collections.Generic;

namespace PersonGame.Application
{
    public class GameService : IGameService
    {
        private readonly IMapper _mapper;
        private readonly IRepository genericRepository;

        public GameService(IMapper mapper, IRepository gameRepository)
        {
            _mapper = mapper;
            genericRepository = gameRepository;
        }

        public List<GameViewDto> GetAll()
        {
            var result = genericRepository.GetAll<Person>();
            return _mapper.Map<List<GameViewDto>>(genericRepository.GetAll<Game>());
        }

        public void Insert(CreateGameDto model)
        {
            var game = new Game(model.Name, model.Genre, model.Rating);
            genericRepository.Add(game);
        }
    }
}