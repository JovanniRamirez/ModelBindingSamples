using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBindingSamples.Models
{

    public class Student
    {
        [Key] //Primary Key
        public int StudentId { get; set; }
    
        public string FullName { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
