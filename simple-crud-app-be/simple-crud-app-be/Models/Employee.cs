using System.ComponentModel.DataAnnotations;

namespace simple_crud_app_be.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public int IsActive { get; set; }
    }
}
