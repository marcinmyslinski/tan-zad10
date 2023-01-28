using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace zad10.Models
{
    public class Studia
    {
        [Key]
        public int IdStudia { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nazwa { get; set;  }
        [Required]
        [MaxLength(200)]
        public string Tryb    { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
