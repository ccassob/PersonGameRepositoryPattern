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
        private readonly IRepository _gameRepository;

        public GameService(IMapper mapper, IRepository gameRepository)
        {
            _mapper = mapper;
            _gameRepository = gameRepository;
        }

        public List<GameViewDto> GetAll()
        {
            return _mapper.Map<List<GameViewDto>>(_gameRepository.GetAll<Game>());
        }

        public void Insert(CreateGameDto model)
        {
            var game = _mapper.Map<Game>(model);
            _gameRepository.Add(game);
        }
    }
}