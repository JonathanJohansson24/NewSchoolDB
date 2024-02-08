using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Models
{
    internal class Student
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string Stu_FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Stu_LastName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Stu_SocialNumber { get; set; }

        public string? Class_Name { get; set; }

        public ICollection<Grade> Grades { get; set;}


    }
}
