using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesPractice.Models
{
    public class JobChangedEventArgs : EventArgs
    {
        public Job Job { get; set; }
        public Func<DateTime, DateTime, int> DateCalculationFunc{ get; set; }

        public JobChangedEventArgs(Job job, Func<DateTime, DateTime, int> dateCalculationFunc)
        {
            Job = job;
            DateCalculationFunc = dateCalculationFunc;
        }
    }
}
