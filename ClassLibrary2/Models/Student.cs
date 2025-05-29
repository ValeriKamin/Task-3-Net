using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainTables.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string FullName { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}