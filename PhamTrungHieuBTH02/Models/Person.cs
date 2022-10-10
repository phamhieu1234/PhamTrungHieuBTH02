using System.Data;
using System.ComponentModel.DataAnnotations;
namespace PhamTrungHieuBTH02.Models
{
    public class Person
    {
        public string? ID {get; set;}
        public string? PersonID {get; set;}
        public string? Personname {get; set;}

        [DataType(DataType.Date)]
        public DateTime namsinh { get; set; }
    }
}