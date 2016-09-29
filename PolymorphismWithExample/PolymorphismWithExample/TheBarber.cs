using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithExample
{
    public class TheBarber:ICurrentJob
    {
        public void Cut()
        {
            Console.WriteLine("I am a barber, to me cut means hair cutting and styling..");
        }
    }
}
