using StudentsMicroService.Domain.Entities;
using StudentsMicroService.Infrastructure.Entities;

namespace StudentsMicroService.Infrastructure.Interfaces
{
    public interface IStudentStateRepository
    {
        Task AddStudent(Domain.Entities.Student student);
        Task<ICollection<StudentState>> GetAllStates();
        Task Purge();
    }
}
