using System.ComponentModel.DataAnnotations;

namespace SmartStudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Department { get; set; }

        public int Semester { get; set; }

        public string Email { get; set; }
    }
}