using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBindingSamples.Models
{

    public class Student
    {
        [Key] //Primary Key
        public int StudentId { get; set; }

        /// <summary>
        /// The legal full (first and last) name of the student.
        /// </summary>
        public required string FullName { get; set; }

        /// <summary>
        /// The date the student was enrolled.
        /// </summary>
        public DateOnly EnrollmentDate { get; set; }
    }
}
