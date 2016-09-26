using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_pattern
{
    public class GoogleObserverClient : IObserver
    {
        Subject newSubject;
        public GoogleObserverClient(Subject subject)
        {
            newSubject = subject;
            newSubject.Register(this);
        }

        public void UpdateStatus(int value)
        {
            Console.WriteLine("Google Observer saying: New value has been added in original server: " + value);
        }
    }
}
