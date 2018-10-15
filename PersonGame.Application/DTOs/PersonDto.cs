using PersonGame.Domain.SharedKernel;

namespace PersonGame.Application.DTOs
{
    public class WritePersonDto
    {
        public string Name { get; set; }
        public int GameId { get; set; }
    }

    public class ViewPersonDto : BaseEntity
    {
        public string Name { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}