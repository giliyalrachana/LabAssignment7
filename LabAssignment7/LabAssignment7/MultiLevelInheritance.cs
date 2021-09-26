using System;

namespace LabAssignment7
{
    class MultiLevelInheritance
    {
        static void Main()
        {
            SuperComputer supercomputer = new SuperComputer();
            supercomputer.ModelNo = 4567;
            supercomputer.ModelName = "SuperSomputer";
            supercomputer.Year = 2007;
            Console.WriteLine(supercomputer.Movie());
            Console.WriteLine(supercomputer.Game());
            Console.WriteLine(supercomputer.MP3());
            Console.ReadLine();

        }
    }
}
