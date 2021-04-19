﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BQS09.Models
{
    public partial class StudentGrade
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public decimal? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Person Student { get; set; }
    }
}
