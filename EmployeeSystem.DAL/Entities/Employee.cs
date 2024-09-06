using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSystem.DAL.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10, 40)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public int? Salary { get; set; }

        public string? Image { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }  

    }   
}
