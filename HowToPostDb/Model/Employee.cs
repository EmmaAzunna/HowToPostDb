using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowToPostDb.Model
{
    public class Employee
    {
        [Key]
        public int? EmpId { get; set; }
        [Required]
        [Column(TypeName="nvarchar(100)")]
        public string EmpName { get; set; } //Employee Name
        [Required]
        [Column(TypeName = "varchar(100)")]  //Employee Contact
        public string EmpContact { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EmpEmail { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string EmpAddress { get; set; }
    }
}
