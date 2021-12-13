using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Try.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string DName { get; set; }
        public string Description { get; set; }
    }
}
