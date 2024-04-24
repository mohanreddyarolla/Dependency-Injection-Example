using DI_Example.Contracts;

namespace DI_Example.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid _id;

        public SingletonService()
        {
            _id = Guid.NewGuid();
        }

        public void DoWork()
        {
            Console.WriteLine($"Singleton service {_id} is doing work.");
        }
    }
}
