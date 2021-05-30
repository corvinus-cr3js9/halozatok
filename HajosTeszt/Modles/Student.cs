using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.Modles
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Neptun { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal? AverageGrade { get; set; }
        public bool IsActive { get; set; }
    }
}
