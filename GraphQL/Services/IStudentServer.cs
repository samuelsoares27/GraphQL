using GraphQL.Model;

namespace GraphQL.Services
{
    public interface IStudentServer
    {
        List<Student> GetStudents();
    }
}
