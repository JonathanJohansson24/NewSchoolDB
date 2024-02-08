using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Models
{
    internal class Grade
    {
        [Key]
        public int ID { get; set; }

        public DateOnly? Grade_Date { get; set; }

        public Student Students { get; set; }

        public GradingScale GradingScales { get; set; }

        public Course Course { get; set; }

        public Employee Employee { get; set; }

    }
}
