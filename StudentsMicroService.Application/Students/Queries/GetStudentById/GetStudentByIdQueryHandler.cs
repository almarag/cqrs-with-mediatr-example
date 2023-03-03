using AutoMapper;
using MediatR;
using StudentsMicroService.Domain.Entities;
using StudentsMicroService.Infrastructure.Interfaces;

namespace StudentsMicroService.Application.Students.Queries.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, Domain.Entities.Student>
    {
        private IMapper _mapper;
        private IStudentRepository _studentRepository;

        public GetStudentByIdQueryHandler(
            IMapper mapper, 
            IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudent(request.Id);

            return _mapper.Map<Student>(student);
        }
    }
}
