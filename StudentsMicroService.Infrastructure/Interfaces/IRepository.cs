namespace StudentsMicroService.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<T> GetByIdAsync(int id);
    }
}
