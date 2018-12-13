using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesPractice
{
    public interface IPrinter
    {
        void Printer_JobChanged(object sender, Models.JobChangedEventArgs e);
    }

    public class Printer : IPrinter
    {
        public Printer()
        {
            Mediator.GetInstance().JobChanged += Printer_JobChanged;
        }

        public void Printer_JobChanged(object sender, Models.JobChangedEventArgs e)
        {
            ProcessFunc(e.Job.StartDate, e.Job.EndDate, "Contract Length is ", e.DateCalculationFunc);
            Console.WriteLine("Beep beep buzz buzz (printer sounds)");
            Console.WriteLine("Title: " + e.Job.Title);
            Console.WriteLine("Start Date: " + e.Job.StartDate);
            Console.WriteLine("End Date: " + e.Job.EndDate );
        }

        public void ProcessFunc(DateTime start, DateTime end, string message,  Func<DateTime, DateTime, int> func)
        {
            var result = func(start, end);
            Console.WriteLine(message + result);
        }
    }
}
