using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Models
{
    internal class EmployeeRole
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string RoleMeaning { get; set; }

        public ICollection<Employee> Employee {  get; set; }
    }
}
