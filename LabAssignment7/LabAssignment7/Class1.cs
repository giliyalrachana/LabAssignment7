using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment7
{
    // This illustrates hybrid inheritance
    class Class1
    {
        static void Main()
        {
            MicroComputercs microcomputercs = new MicroComputercs();
            microcomputercs.ModelNo = 4567;
            microcomputercs.ModelName = "MicroSomputer";
            microcomputercs.Year = 2007;

            Console.WriteLine(microcomputercs.AboutComputer());
            Console.WriteLine(microcomputercs.Movie());
            Console.WriteLine(microcomputercs.Game());
            Console.WriteLine(microcomputercs.Camera());
            Console.ReadLine();
        }
       
    }
}
