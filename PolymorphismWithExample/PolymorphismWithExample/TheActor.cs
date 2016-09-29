using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithExample
{
    public class TheActor:ICurrentJob
    {
        public void Cut()
        {
            Console.WriteLine("I am an actor, to me cut means stop acting..");
        }
    }
}
