using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhamTrungHieuExcel.Models
{
    public class Employee
    {
        public string? EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
          public string? FacultyID {get; set;}
        [ForeignKey("FacultyID")]
        public Faculty? Faculty {get; set;}
        public string? EmployeeAdderss { get; set; }
    }
}