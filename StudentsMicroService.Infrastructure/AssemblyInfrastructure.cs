namespace StudentsMicroService.Infrastructure
{
    using System.Reflection;

    public class AssemblyInfrastructure
    {
        public Assembly GetAssembly()
        {
            return typeof(AssemblyInfrastructure).GetTypeInfo().Assembly;
        }
    }
}
