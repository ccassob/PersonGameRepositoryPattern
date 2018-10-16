using PersonGame.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonGame.Application
{
    public interface IPersonService
    {
        List<ViewPersonDto> GetAll();
        void Insert(CreatePersonDto model);
        void Update(int id, ViewPersonDto model);
        void Delete(int id);
    }
}
