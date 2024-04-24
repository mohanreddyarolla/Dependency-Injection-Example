using DI_Example.Contracts;
using DI_Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Example.Controllers
{
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ITask1 _task1;
        private readonly ITask2 _task2;

        public TestController(
            ITask1 task1,
            ITask2 task2)
        {
            _task1 = task1;
            _task2 = task2;
        }

        [HttpGet("Test-Transient")]
        public IActionResult TestTransient()
        {
            Console.WriteLine("Test result for Transient");
            // Executes two different tasks, each providing unique work for transient tasks, in a single request
            _task1.DoTransientWork();
            _task2.DoTransientWork();
            return Ok();
        }

        [HttpGet("Test-Scoped")]
        public IActionResult TestScoped()
        {
            // Executes two different tasks, each providing unique work for scoped tasks, in a single request
            // But you get different works assigned for another request
            Console.WriteLine("Test result for Scoped");
            _task1.DoScopedWork();
            _task2.DoScopedWork();
            return Ok();
        }

        [HttpGet("Test-SigleTon")]
        public IActionResult TestSigleTon()
        {
            // Executes two different tasks, each providing same work for singleton tasks, in a any request
            Console.WriteLine("Test result for SigleTon");
            _task1.DoSingletonWork();
            _task2.DoSingletonWork();
            return Ok();
        }

    }
}
