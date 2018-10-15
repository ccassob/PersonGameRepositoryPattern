using PersonGame.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonGame.Application
{
    public interface IPersonService
    {
        List<ViewPersonDto> GetAll();
        void Insert(WritePersonDto model);
        void Update(int id, WritePersonDto model);
        void Delete(int id);
    }
}
