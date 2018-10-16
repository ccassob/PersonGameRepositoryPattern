using System.ComponentModel.DataAnnotations;

namespace PersonGame.Domain.SharedKernel
{
    public abstract class BaseEntity<TPrimitive> where TPrimitive : struct
    {
        [Key]
        public TPrimitive Id { get; set; }
    }
}