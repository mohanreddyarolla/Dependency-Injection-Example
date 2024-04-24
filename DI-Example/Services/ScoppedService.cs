using DI_Example.Contracts;

namespace DI_Example.Services
{
    public class ScopedService : IScopedService
    {
        private readonly Guid _id;

        public ScopedService()
        {
            _id = Guid.NewGuid();
        }

        public void DoWork()
        {
            Console.WriteLine($"Scoped service {_id} is doing work.");
        }
    }
}
