using MediatR;
using StudentsMicroService.Application;
using StudentsMicroService.Application.Students.Queries.GetStudentById;
using StudentsMicroService.Infrastructure;
using StudentsMicroService.Infrastructure.Interfaces;
using StudentsMicroService.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(
    new AssemblyInfrastructure().GetAssembly()
);
builder.Services.AddMediatR(cfg => 
    cfg.RegisterServicesFromAssemblyContaining<AssemblyApplication>()
);

builder.Services.AddTransient<IStudentRepository, StudentRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGet("/Students/{id}", async (IMediator mediator, int id) =>
{
    var query = new GetStudentByIdQuery() { Id = id };
    return await mediator.Send(query);
})
.WithName("Students");

app.Run();