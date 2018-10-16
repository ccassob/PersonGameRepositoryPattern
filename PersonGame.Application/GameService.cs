﻿using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using PersonGame.Domain.Interface;
using PersonGame.Infrastructure.Data;
using System;
using System.Collections.Generic;

namespace PersonGame.Application
{
    public class GameService : IGameService
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;

        public GameService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<GameViewDto> GetAll()
        {
            return _mapper.Map<List<GameViewDto>>(_unitOfWork.GameRepository.GetAll());
        }

        public void Insert(WriteGameDto model)
        {
            var game = new Game(model.Name, model.Genre, model.Rating);
            _unitOfWork.GameRepository.Add(game);
            _unitOfWork.Commit();
        }

        public void Update(int id, WriteGameDto model)
        {
            var game = _unitOfWork.GameRepository.GetById(id);

            if (game == null)
            {
                throw new Exception("El juego no existe");
            }

            game = _mapper.Map<Game>(model);
            _unitOfWork.GameRepository.Update(game);
            _unitOfWork.Commit();
        }


        public void Delete(int id)
        {
            var game = _unitOfWork.GameRepository.GetById(id);
            if (game == null)
            {
                throw new ArgumentNullException("No fue encontrado");
            }

            _unitOfWork.GameRepository.Delete(game);
            _unitOfWork.Commit();
        }
    }
}