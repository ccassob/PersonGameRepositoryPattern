using PersonGame.Domain.SharedKernel;

namespace PersonGame.Application.DTOs
{
    public class CreatePersonDto
    {
        public string Name { get; set; }
        public int GameId { get; set; }
    }

    public class ViewPersonDto : BaseEntity<int>
    {
        public string Name { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
    }

    public class UpdatePersonDto : BaseEntity<int>
    {
        public string Name { get; set; }
        public int GameId { get; set; }
    }
}