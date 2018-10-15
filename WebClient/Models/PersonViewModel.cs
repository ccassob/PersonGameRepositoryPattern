using Microsoft.AspNetCore.Mvc.Rendering;
using PersonGame.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models
{
    public class PersonViewModel
    {
        public CreatePersonDto personDto { get; set; }
        List<SelectListItem> ListItemsGames {get ; set; }
    }
}
