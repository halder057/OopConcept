using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_pattern
{
    public interface ISubject
    {
        void Register(IObserver ob);
        void UnRegister(IObserver ob);
        void NotifyAll();
    }
}
