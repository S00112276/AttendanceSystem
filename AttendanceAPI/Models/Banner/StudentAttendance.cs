using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceAPI.Models
{
    public class StudentAttendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("attendee")]
        public int StudentID { get; set; }
        public bool attended { get; set; }

        public virtual Student attendee { get; set; }
        public virtual Attendance AttendanceOf { get; set; }
    }
}