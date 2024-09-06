using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.DAL.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<Employee>? employeeName { get; set; }

    }
}
