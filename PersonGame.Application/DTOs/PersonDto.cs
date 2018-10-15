using PersonGame.Domain.SharedKernel;

namespace PersonGame.Application.DTOs
{
    public class CreatePersonDto
    {
        public string Name { get; set; }
        public int GameId { get; set; }
    }

    public class PersonViewDto : BaseEntity
    {
        public string Name { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}