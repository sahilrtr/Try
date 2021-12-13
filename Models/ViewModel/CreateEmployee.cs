using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try.Models.ViewModel
{
    public class CreateEmployee
    {
      
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
    }
}
