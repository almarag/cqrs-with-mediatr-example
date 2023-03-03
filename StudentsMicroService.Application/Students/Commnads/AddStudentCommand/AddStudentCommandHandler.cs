using AutoMapper;
using MediatR;
using StudentsMicroService.Domain.Entities;
using StudentsMicroService.Infrastructure.EF;
using StudentsMicroService.Infrastructure.Interfaces;

namespace StudentsMicroService.Application.Students.Commnads.AddStudentCommand
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand>
    {
        private IMapper _mapper;
        private IStudentStateRepository _repository;

        public AddStudentCommandHandler(
            IMapper mapper,
            IStudentStateRepository repository
        )
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var newStudent = _mapper.Map<Student>(request.Student);

            await _repository.AddStudent(newStudent);
        }
    }
}
