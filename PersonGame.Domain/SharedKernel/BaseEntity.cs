using System.ComponentModel.DataAnnotations;

namespace PersonGame.Domain.SharedKernel
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}