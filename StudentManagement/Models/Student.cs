using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Property name should match the database column name.")]
        public string? Faculty { get; set; }

        public string Batch { get; set; } = string.Empty;
        [Range(0, 10)]
        public int ContactNumber { get; set; }

        public string Email { get; set; } = string.Empty;

    }
}
