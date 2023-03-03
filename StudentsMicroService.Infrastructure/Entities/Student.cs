using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace StudentsMicroService.Infrastructure.Entities
{
    public class Student
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public int StudentId { get; set; }
        public PersonalData PersonalData { get; set; }
        public AcademicData AcademicData { get; set; }
    }
}
