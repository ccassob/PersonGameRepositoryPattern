using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using PersonGame.Domain.Interface;
using System;
using System.Collections.Generic;

namespace PersonGame.Application
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repository;

        public PersonService(IMapper mapper, IRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<ViewPersonDto> GetAll()
        {
            return _mapper.Map<List<ViewPersonDto>>(_repository.GetAll<Person>(c => c.Game));
        }

        public void Insert(CreatePersonDto model)
        {
            var game = _repository.GetById<Game>(model.GameId);

            if (game == null)
            {
                throw new Exception("El juego no existe");
            }

            var person = new Person(model.Name, model.GameId);
            _repository.Add(person);
        }

        public void Update(int id, UpdatePersonDto model)
        {
            var person = _repository.GetById<Person>(id);

            var game = _repository.GetById<Game>(model.GameId);

            if (game == null)
            {
                throw new Exception("El juego no existe");
            }

            person = _mapper.Map<Person>(model);
            _repository.Update(person);
        }

        public void Delete(int id)
        {
            var person = _repository.GetById<Person>(id);
            if (person == null)
            {
                throw new ArgumentNullException("No fue encontrado");
            }

            _repository.Delete(person);
        }
    }
}