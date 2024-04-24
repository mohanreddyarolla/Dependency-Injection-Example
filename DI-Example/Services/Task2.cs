using DI_Example.Contracts;
using System.Security.Cryptography;

namespace DI_Example.Services
{
    public class Task2 : ITask2
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;

        public Task2(
            ITransientService transientService,
            IScopedService scopedService,
            ISingletonService singletonService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
        }

        public void DoTransientWork()
        {
            _transientService.DoWork();
        }

        public void DoScopedWork()
        {
            _scopedService.DoWork();
        }

        public void DoSingletonWork()
        {
            _singletonService.DoWork();
        }
    }
}
