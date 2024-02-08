using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Models
{
    internal class Course
    {
        [Key]
        public int ID { get; set; }

        public bool IsActive { get; set; }
        public string? Course_Name {  get; set; }
        
        public ICollection<Grade> Grades { get; set; }



    }
}
