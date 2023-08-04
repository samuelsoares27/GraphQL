using GraphQL.Model;
using System.Reflection.Metadata.Ecma335;

namespace GraphQL.Services
{
    public class StudentServer : IStudentServer
    {
        public List<Student> GetStudents()
        {
            List<Student> student = new ();

            for (int i = 0; i < 10; i++)
            {
                student.Add(new Student(){
                    Id = i,
                    Name = $"Student {i}",
                    Roll = i
                });
            }
            return student;
    }
    }
}
