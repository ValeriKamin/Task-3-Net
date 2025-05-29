using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainTables.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public int Year { get; set; }
    }
}