using System.Data;
using System.ComponentModel.DataAnnotations;
namespace PhamTrungHieuBTH02.Models
{
    public class Person
    {
        [Required]
        public string? ID {get; set;}
        [Required]
        public string? PersonID {get; set;}
        [Required]
        public string? Personname {get; set;}

        [DataType(DataType.Date)]
        public DateTime namsinh { get; set; }
    }
}