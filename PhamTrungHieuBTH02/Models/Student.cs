using System.ComponentModel.DataAnnotations;
namespace PhamTrungHieuBTH02.Models;
public class Student
    {
        [Required]
     public string? ID {get; set;}
       [Required]
       public string? StudentName {get; set;} 
       [Required]
       public string? Address {get; set;}
       [Required]
       public string? SĐT {get; set;}
      
    }
