using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICurrentJob> currentJobHolder = new List<ICurrentJob>();
            currentJobHolder.Add(new TheActor());
            currentJobHolder.Add(new TheBarber());
            currentJobHolder.Add(new TheDoctor());

            foreach (var employee in currentJobHolder)
            {
                employee.Cut();
            }
            Console.Read();
        }
    }
}
