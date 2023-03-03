using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsMicroService.Domain.Entities;

namespace StudentsMicroService.Application.Students.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public int Id { get; set; }
    }
}
