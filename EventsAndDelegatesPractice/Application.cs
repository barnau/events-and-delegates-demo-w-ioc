using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsAndDelegatesPractice.Models;

namespace EventsAndDelegatesPractice
{
    public interface IApplication
    {
        void Run();
    }

    public class Application : IApplication
    {
        private readonly IMediator _mediator;
        private readonly IPrinter _printer;
        public Application(IMediator mediator, IPrinter printer)
        {
            _mediator = mediator;
            _printer = printer;
        }
        public void Run()
        {
            _mediator.OnJobChanged(new Job()
                {
                    Title = "this job title",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(30)
                },
                (start, end) => (int)(end - start).TotalDays);
        }
    }
}
