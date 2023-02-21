using AutoMapper;
using StudentsMicroService.Infrastructure.Mappings;

namespace StudentsMicroService.Test.Mappings
{
    public class MappingTests
    {
        [Fact]
        public void TestStudentMapping()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(new MappingProfile());
            });
            var mapper = new Mapper(config);

            var testStudent = new Domain.Entities.Student()
            {
                Id = 1,
                AcademicData = new Domain.Entities.AcademicData()
                {
                    StudentId = 1,
                    Grade = 10
                },
                PersonalData = new Domain.Entities.PersonalData()
                {
                    StudentId = 1,
                    Name = "TEST",
                    Email = "test@example.com",
                    LastName = "USER"
                }
            };

            var result = mapper.Map<Infrastructure.Entities.Student>(testStudent);

            Assert.IsType<Infrastructure.Entities.Student>(result);
        }
    }
}
