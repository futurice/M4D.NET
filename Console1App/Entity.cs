using System;
using System.ComponentModel.DataAnnotations;

namespace Console1App
{
    public class Entity
    {
        [Required]
        public virtual Guid Id { get; set; }
    }
}