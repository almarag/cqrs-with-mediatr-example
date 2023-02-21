using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMicroService.Application.Students.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<Domain.Entities.Student>
    {
        public int Id { get; set; }
    }
}
