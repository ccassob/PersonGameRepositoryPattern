using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using PersonGame.Domain.Interface;
using PersonGame.Infrastructure.Data;
using System.Collections.Generic;

namespace PersonGame.Application
{
    public class PersonService : IPersonService
    {
        readonly IMapper _mapper;
        readonly IRepository repositoryPerson;

        public PersonService(IMapper mapper, IRepository personRepository)
        {
            _mapper= mapper;
            repositoryPerson = personRepository;
        }

        public List<PersonViewDto> GetAll()
        {
            return _mapper.Map<List<PersonViewDto>>(repositoryPerson.GetAll<Person>());
        }

        public void Insert(CreatePersonDto model)
        {
            var person = new Person(model.Name, model.GameId);
            repositoryPerson.Add(person);
        }
    }
}