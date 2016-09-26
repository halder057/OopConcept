using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_pattern
{
    public class Subject : ISubject
    {
        List<IObserver> listOfNotifiableObject = new List<IObserver>();
        private int _newValue;
        public int NewValue
        {
            get { return _newValue; }
            set
            {
                if (value > 10)
                {
                    _newValue = value;
                    NotifyAll();
                };
            }
        }
        public void Register(IObserver ob)
        {
            listOfNotifiableObject.Add(ob);
        }

        public void UnRegister(IObserver ob)
        {
            listOfNotifiableObject.Remove(ob);
        }
        public void NotifyAll()
        {
            foreach (var item in listOfNotifiableObject)
            {
                item.UpdateStatus(NewValue);
            }
        }
    }
}
