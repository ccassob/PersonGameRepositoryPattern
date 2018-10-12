using PersonGame.Domain.SharedKernel;

namespace PersonGame.Application.DTOs
{
    public class PersonDto : BaseEntity
    {
        public string Name { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}