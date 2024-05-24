using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolClassProject
{
    public class Class
    {
        public Class()
        {
            SchoolYear = 0;
            Id = string.Empty;
            MonthlyPaid = 0;
            Students = 0;
        }

        public Class(int schoolYear, string id, int monthlyPaid, int students)
        {
            SchoolYear = schoolYear;
            Id = id;
            MonthlyPaid = monthlyPaid;
            Students = students;
        }

        public int SchoolYear { get; set; }
        public string Id { get; set; }
        public int MonthlyPaid { get; set; }
        public int Students { get; set; }

        public bool EqualTo(Class other)
        {
            return SchoolYear == other.SchoolYear && Id == other.Id && MonthlyPaid == other.MonthlyPaid;
        }

        public override string ToString()
        {
            return $"{SchoolYear}.{Id} ({MonthlyPaid} Ft).";
        }

        public bool IsMorePaid(Class other)
        {
            return MonthlyPaid < other.MonthlyPaid;
        }

        public bool MostPaydSchoolClass(Class other)
        {
            return MonthlyPaid < other.MonthlyPaid;
        }
    }
}
