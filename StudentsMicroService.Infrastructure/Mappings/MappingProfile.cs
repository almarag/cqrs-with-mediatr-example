using AutoMapper;
using StudentsMicroService.Infrastructure.Entities;

namespace StudentsMicroService.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, Domain.Entities.Student>();
            CreateMap<AcademicData, Domain.Entities.AcademicData>();
            CreateMap<PersonalData, Domain.Entities.PersonalData>();

            CreateMap<Domain.Entities.Student, Student>();
            CreateMap<Domain.Entities.AcademicData, AcademicData>();
            CreateMap<Domain.Entities.PersonalData, PersonalData>();
        }
    }
}