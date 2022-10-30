using System.Data;
namespace PhamTrungHieuBTH02.Models;
using System.ComponentModel.DataAnnotations;

    public class Customer
    {
         [Required]
        public string? ID {get; set;}
        [Required]
        public string? MaKH {get; set;}
         [Required]
        public int SĐT {get; set;}
        [Required]
        public string? GioiTinh {get; set;}
    }

