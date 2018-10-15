using PersonGame.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonGame.Application.DTOs
{
    public class WriteGameDto
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public decimal Rating { get; set; }
    }

    public class GameViewDto : BaseEntity
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public decimal Rating { get; set; }
    }
}
