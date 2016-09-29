using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithExample
{
    public class TheDoctor:ICurrentJob
    {
        public void Cut()
        {
            Console.WriteLine("I am a doctor, to me cut means surgery..");
        }
    }
}
