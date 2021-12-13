using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try.Models.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public string DName { get; set; }
        public string Description { get; set; }
    }
}
