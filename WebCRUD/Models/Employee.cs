using System.ComponentModel.DataAnnotations;

namespace WebCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string EmpName { get; set; }

        public string EmpDepartment { get; set; }
    }
}
