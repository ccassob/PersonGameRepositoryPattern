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
            CreateMap<Person, CreatePersonDto>();
            CreateMap<ViewPersonDto, Person>();
            CreateMap<CreatePersonDto, Person>()
                .ForMember(dest => dest.Id, opt => opt.UseDestinationValue());

            CreateMap<Game, GameViewDto>();
            CreateMap<Game, CreateGameDto>();
        }
    }
}
