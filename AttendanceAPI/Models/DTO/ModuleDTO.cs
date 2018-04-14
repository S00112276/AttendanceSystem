using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceAPI.Models.DTO
{
    public class ModuleDTO
    {
        public int id { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }
    }
}