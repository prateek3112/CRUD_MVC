using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppMVC.Models
{
    public class Employee
    { 
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="fuck off")]
        [DisplayName("Full Name")]
        public string FullName  { get; set; }
        [Column(TypeName = "varchar(10)")]
        public int EmpCode  { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string  position { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Location { get; set; }
    }
}
