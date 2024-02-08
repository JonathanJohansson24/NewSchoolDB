using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Models
{
    internal class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string Emp_FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Emp_LastName { get; set;}
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary {  get; set; }
        [Required]
        public DateOnly Date_Of_Employment { get; set; }
        [Required]
       
        public EmployeeRole Role { get; set; }
        public ICollection<Grade> Grades { get; set;}


    }
}
