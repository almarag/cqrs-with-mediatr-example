using AutoMapper;

namespace StudentsMicroService.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Infrastructure.Entities.Student, Domain.Entities.Student>();
            CreateMap<Infrastructure.Entities.AcademicData, Domain.Entities.AcademicData>();
            CreateMap<Infrastructure.Entities.PersonalData, Domain.Entities.PersonalData>();

            CreateMap<Domain.Entities.Student, Infrastructure.Entities.Student>();
            CreateMap<Domain.Entities.AcademicData, Infrastructure.Entities.AcademicData>();
            CreateMap<Domain.Entities.PersonalData, Infrastructure.Entities.PersonalData>();
        }
    }
}
