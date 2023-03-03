using StudentsMicroService.Domain.Entities;

namespace StudentsMicroService.Application.Students.Commnads.AddStudentCommand
{
    public class AddStudentCommandModel
    {
        public PersonalData PersonalData { get; set; }
        public AcademicData AcademicData { get; set; }
    }
}
