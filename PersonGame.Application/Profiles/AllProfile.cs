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
            CreateMap<Person, ViewPersonDto>();
            CreateMap<Person, WritePersonDto>();
            CreateMap<ViewPersonDto, Person>();
            CreateMap<WritePersonDto, Person>();

            CreateMap<Game, GameViewDto>();
            CreateMap<Game, WriteGameDto>();
        }
    }
}
