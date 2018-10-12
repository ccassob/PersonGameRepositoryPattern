using PersonGame.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonGame.Application
{
    public interface IPersonService
    {
        List<PersonDto> GetAll();
    }
}
