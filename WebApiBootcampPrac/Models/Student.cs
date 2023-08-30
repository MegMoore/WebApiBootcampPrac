using System.ComponentModel.DataAnnotations;

namespace WebApiBootcampPrac.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        [StringLength(30)]
        public string Email { get; set; } = string.Empty;
        [StringLength(30)]
        public string Phone { get; set; } = string.Empty;
    }
}
