using AutoMapper;
using MediatR;
using StudentsMicroService.Domain.Entities;

namespace StudentsMicroService.Application.Students.Queries.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, Domain.Entities.Student>
    {
        private IMapper _mapper;

        public GetStudentByIdQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var simulatedDbResponse = new Infrastructure.Entities.Student()
            {
                Id = 1,
                AcademicData = new Infrastructure.Entities.AcademicData()
                {
                    StudentId = 1,
                    Grade = 10
                },
                PersonalData = new Infrastructure.Entities.PersonalData()
                {
                    StudentId = 1,
                    Name = "TEST",
                    Email = "test@example.com",
                    LastName = "USER"
                }
            };

            return Task.FromResult(_mapper.Map<Domain.Entities.Student>(simulatedDbResponse));
        }
    }
}
