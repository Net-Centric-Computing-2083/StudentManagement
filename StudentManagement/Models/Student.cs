namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Faculty { get; set; }

        public string Batch { get; set; } = string.Empty;

        public int ContactNumber { get; set; }

        public string Email { get; set; } = string.Empty;

    }
}
