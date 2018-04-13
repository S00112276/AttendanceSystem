using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceAPI.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("StudentEnrolled")]
        public int StudentId { get; set; }
        [ForeignKey("EnrolledOn")]
        public int ModuleId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "date")]
        public DateTime? EnrollmentDate { get; set; }
        public virtual Student StudentEnrolled { get; set; }
        public virtual Module EnrolledOn { get; set; }
    }
}