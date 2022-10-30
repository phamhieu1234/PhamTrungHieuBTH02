using System.Data;
namespace PhamTrungHieuBTH02.Models;
using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Required]
        public string? ID {get; set;}
        [Required]
        public string? MaNV {get; set;}
        [Required]
        public string? phongban {get; set;}
        [Required]
        public string? tên {get; set;}
        
    }
