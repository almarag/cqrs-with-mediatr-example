using MediatR;
using StudentsMicroService.Domain.Entities;

namespace StudentsMicroService.Application.Students.Commnads.AddStudentCommand
{
    public class AddStudentCommand : IRequest
    {
        public AddStudentCommandModel Student { get; set; }
    }
}
