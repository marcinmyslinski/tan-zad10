using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace zad10.Models
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        [Required]
        [MaxLength(100)]
        public string Imie { get; set; }
        [Required] // component data adnotation
        [MaxLength(200)]
        public string Nazwisko { get; set; }
        [MaxLength(200)]
        public string NrIndeksu     { get; set; }
        public int RokStudiow { get; set; }
        
        public int IdStudia { get; set; }
        [ForeignKey(nameof(IdStudia))]
        public  virtual Studia Studia { get; set; } //public  virtual Studia IdStatusNavigation { get; set; }
    }
}
