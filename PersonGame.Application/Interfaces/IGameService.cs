﻿using PersonGame.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonGame.Application
{
    public interface IGameService
    {
        List<GameViewDto> GetAll();
        void Insert(CreateGameDto model);
    }
}
