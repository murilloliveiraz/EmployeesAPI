using EmployeesAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeesAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DepartmentEnums Department { get; set; }
        public bool Status { get; set; }
        public PeriodEnums Period { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime UpdatedDate { get; set; } = DateTime.Now.ToLocalTime();
    }
}
