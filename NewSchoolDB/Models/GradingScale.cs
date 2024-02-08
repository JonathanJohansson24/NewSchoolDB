using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Models
{
    internal class GradingScale
    {
        public int ID { get; set; }

        public string Grade_Meaning { get; set; }

        public int Grade_Points { get; set; }

        public ICollection<Grade> Grades { get; set; }



    }
}
