using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using StudentsMicroService.Infrastructure.Entities;
using StudentsMicroService.Infrastructure.Interfaces;

namespace StudentsMicroService.Infrastructure.Repositories
{
    public class StudentRepository : MongoRepository, IStudentRepository
    {
        private IMongoCollection<Student> _collection;

        public StudentRepository(
            IConfiguration configuration
        ) : base(configuration) 
        {
            _collection = _database.GetCollection<Student>("students");
        }

        public async Task<Student> GetStudent(int studentId)
        {
            var filter = Builders<Student>.Filter.Eq("StudentId", studentId);
            return _collection.FindAsync(filter).Result.FirstOrDefault();
        }
    }
}
