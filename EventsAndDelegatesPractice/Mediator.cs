using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsAndDelegatesPractice.Models;

namespace EventsAndDelegatesPractice
{
    public interface IMediator
    {
        event EventHandler<JobChangedEventArgs> JobChanged;
        void OnJobChanged(Job job, Func<DateTime, DateTime, int> func);
    }

    public class Mediator : IMediator
    {
        private  static readonly Mediator _instance = new Mediator();


        private Mediator(){}

        public static Mediator GetInstance()
        {
            return _instance;
        }

        public event EventHandler<JobChangedEventArgs> JobChanged;
        

        public void OnJobChanged(Job job, Func<DateTime, DateTime, int> func)
        {
            var del = JobChanged;
            del?.Invoke(this, new JobChangedEventArgs(job, func));
        }
    }
}
