using AutoMapper;
using StudentsMicroService.Domain.Entities;

namespace StudentsMicroService.Application.Students.Commnads.AddStudentCommand
{
    public class AddStudentCommandMapping : Profile
    {
        public AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommandModel, Student>()
                .ForMember(
                    dest => dest.StudentId,
                    opt => opt.MapFrom(src => 0)
                )
                .ForMember(
                    dest => dest.PersonalData,
                    opt => opt.MapFrom(src => src.PersonalData)
                )
                .ForMember(
                    dest => dest.AcademicData,
                    opt => opt.MapFrom(src => src.AcademicData)
                );
        }
    }
}
