using DI_Example.Contracts;

namespace DI_Example.Services
{
    public class TransientService : ITransientService
    {
        private readonly Guid _id;

        public TransientService()
        {
            _id = Guid.NewGuid();
        }

        public void DoWork()
        {
            Console.WriteLine($"Transient service {_id} is doing work.");
        }
    }
}
