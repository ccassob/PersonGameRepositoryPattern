using AutoMapper;
using PersonGame.Application.DTOs;
using PersonGame.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonGame.Application.Profiles
{
    public class AllProfile : Profile
    {
        public AllProfile()
        {
            CreateMap<Person, PersonViewDto>();
            CreateMap<Person, CreatePersonDto>();
            CreateMap<PersonViewDto, Person>();
            CreateMap<CreatePersonDto, Person>();

            CreateMap<Game, GameViewDto>();
            CreateMap<Game, CreateGameDto>();
            CreateMap<GameViewDto, Game>();
            CreateMap<CreateGameDto, Game>();
        }
    }
}
