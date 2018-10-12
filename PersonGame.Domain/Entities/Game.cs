using PersonGame.Domain.SharedKernel;
using System.ComponentModel.DataAnnotations;

namespace PersonGame.Domain
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public decimal Rating { get; set; }
    }
}