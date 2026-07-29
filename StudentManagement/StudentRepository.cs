using StudentManagement.Models;

namespace StudentManagement
{
    public class StudentRepository
    {
        private readonly List<Student> students = new List<Student>
        {
            new Student
            {
            Id = 1,
            Name = "John Doe",
            Faculty = "Engineering",
            Batch = "2022",
            ContactNumber = 1234567890,
            Email = "John@gmail.com"
        },
                new Student {
            Id = 2,
                    Name = "Jane Smith",
                    Faculty = "Science",
                    Batch = "2021",
                    ContactNumber = 987654321,
                    Email = "Jane@gmail.com"
                },
        };

        public List<Student> GetAll()
        {
            return new  List<Student>(students);
        }
    }
}
