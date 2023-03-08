using Microsoft.EntityFrameworkCore;
using StudentsMicroService.Infrastructure.Constants;
using StudentsMicroService.Infrastructure.EF;
using StudentsMicroService.Infrastructure.Entities;
using StudentsMicroService.Infrastructure.Interfaces;
using System.Text.Json;

namespace StudentsMicroService.Infrastructure.Repositories
{
    public class StudentStateRepository : IStudentStateRepository
    {
        private ApplicationDbContext _context;
        public StudentStateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddStudent(Domain.Entities.Student student)
        {
            var newState = new StudentState()
            {
                CreatedDate = DateTime.Now,
                Action = ActionConstants.ACTION_ADD_STUDENT,
                Data = JsonSerializer.Serialize(student)
            };

            _context.Add(newState);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<StudentState>> GetAllStates()
        {
            return await _context.StudentStates.ToListAsync();
        }

        public async Task Purge()
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM StudentStates");
        }
    }
}
