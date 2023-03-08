// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentMicroService.Sync.Services;
using StudentsMicroService.Infrastructure.EF;
using StudentsMicroService.Infrastructure.Interfaces;
using StudentsMicroService.Infrastructure.Repositories;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddDbContext<ApplicationDbContext>();
        services.AddTransient<IStudentRepository, StudentRepository>();
        services.AddTransient<IStudentStateRepository, StudentStateRepository>();
    })
    .Build();

using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;

IStudentRepository studentRepository = (IStudentRepository)provider.GetService(typeof(IStudentRepository));
IStudentStateRepository studentStateRepository = (IStudentStateRepository)provider.GetService(typeof(IStudentStateRepository));

Console.WriteLine("Starting sync...");

var service = new SyncService(studentRepository, studentStateRepository);
await service.Sync();

Console.WriteLine("Sync finished");

