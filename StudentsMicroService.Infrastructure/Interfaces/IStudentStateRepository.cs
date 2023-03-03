using StudentsMicroService.Domain.Entities;

namespace StudentsMicroService.Infrastructure.Interfaces
{
    public interface IStudentStateRepository
    {
        Task AddStudent(Student student);
    }
}
