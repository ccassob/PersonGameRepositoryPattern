using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using PersonGame.Domain.Interface;
using PersonGame.Infrastructure.Data;
using System;
using System.Collections.Generic;

namespace PersonGame.Application
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;

        public PersonService(IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = new UnitOfWork();
        }

        public List<ViewPersonDto> GetAll()
        {
            return _mapper.Map<List<ViewPersonDto>>(_unitOfWork.PersonRepository.GetAll(c => c.Game));
        }

        public void Insert(CreatePersonDto model)
        {
            var game = _unitOfWork.PersonRepository.GetById(model.GameId);

            if (game == null)
            {
                throw new Exception("El juego no existe");
            }

            var person = new Person(model.Name, model.GameId);
            _unitOfWork.PersonRepository.Add(person);
            _unitOfWork.Commit();
        }

        public void Update(int id, UpdatePersonDto model)
        {
            var person = _unitOfWork.PersonRepository.GetById(id);

            var game = _unitOfWork.GameRepository.GetById(model.GameId);

            if (game == null)
            {
                throw new Exception("El juego no existe");
            }

            person = _mapper.Map<Person>(model);
            _unitOfWork.PersonRepository.Update(person);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            var person = _unitOfWork.PersonRepository.GetById(id);
            if (person == null)
            {
                throw new ArgumentNullException("No fue encontrado");
            }

            _unitOfWork.PersonRepository.Delete(person);
            _unitOfWork.Commit();
        }
    }
}