using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using StudentsMicroService.Infrastructure.Entities;
using StudentsMicroService.Infrastructure.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            return await _collection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public async Task AddStudent(StudentState student)
        {
            var studentData = JsonSerializer.Deserialize<Student>(student.Data);
            var lastStudentId = await GetLastStudentCount();

            if (studentData != null)
            {
                studentData.StudentId = Convert.ToInt32(lastStudentId)+1;
                await _collection.InsertOneAsync(studentData);
            }
        }

        public async Task<long> GetLastStudentCount()
        {
            return await _collection.CountDocumentsAsync(new BsonDocument());
        }
    }
}
