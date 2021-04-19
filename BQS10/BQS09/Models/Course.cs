using System;
using System.Collections.Generic;

#nullable disable

namespace BQS09.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
            Outlines = new HashSet<Outline>();
            StudentGrades = new HashSet<StudentGrade>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual OnsiteCourse OnsiteCourse { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<Outline> Outlines { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}
