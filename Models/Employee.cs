using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementApp.Models
{
    public partial class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public double? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
