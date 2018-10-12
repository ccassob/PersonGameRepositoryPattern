using PersonGame.Domain.SharedKernel;
using System.ComponentModel.DataAnnotations;

namespace PersonGame.Domain
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public Game Game { get; set; }

        public int GameId { get; set; }
    }
}