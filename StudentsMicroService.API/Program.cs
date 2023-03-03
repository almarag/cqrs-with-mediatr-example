using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentsMicroService.Application;
using StudentsMicroService.Application.Students.Commnads.AddStudentCommand;
using StudentsMicroService.Application.Students.Queries.GetStudentById;
using StudentsMicroService.Infrastructure;
using StudentsMicroService.Infrastructure.EF;
using StudentsMicroService.Infrastructure.Interfaces;
using StudentsMicroService.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(
    new AssemblyInfrastructure().GetAssembly(),
    new AssemblyApplication().GetAssembly()
);

builder.Services.AddMediatR(cfg => 
    cfg.RegisterServicesFromAssemblyContaining<AssemblyApplication>()
);

builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<IStudentStateRepository, StudentStateRepository>();

builder.Services.AddDbContext<ApplicationDbContext>();

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
});

app.MapPost("/Students", async (IMediator mediator, AddStudentCommand command) =>
{
    await mediator.Send(command);
    return Results.StatusCode(201);
});

app.Run();