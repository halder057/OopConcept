using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            GoogleObserverClient googleObserverClient = new GoogleObserverClient(subject);
            MicrosoftObserver microsoftObserver = new MicrosoftObserver(subject);
            AmazonObserver amazonObserver = new AmazonObserver(subject);
            subject.NewValue = 11;
            subject.UnRegister(microsoftObserver);
            subject.NewValue = 12;

            Console.ReadLine();
        }
    }
}
