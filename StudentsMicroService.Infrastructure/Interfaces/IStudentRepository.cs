using StudentsMicroService.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMicroService.Infrastructure.Interfaces
{
    public interface IStudentRepository : IRepository<StudentState>
    {
        Task<Student> GetStudent(int studentId);
    }
}
