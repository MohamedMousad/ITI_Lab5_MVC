using EmployeeSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.BLL.ModelVM.EmployeeVM
{
    public class GetAllEmployeeVM
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
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; }
        public Department? Department { get; set; }
        public string? DepartmentName { get; set; }

    }
}
