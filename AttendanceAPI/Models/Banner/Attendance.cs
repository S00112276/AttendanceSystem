﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AttendanceAPI.Models
{
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime AttDate { get; set; }
        public virtual Delivery ForDelivery { get; set; }
        public virtual ICollection<StudentAttendance> attendees { get; set; }
    }
}