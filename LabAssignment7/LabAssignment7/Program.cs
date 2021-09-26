using System;


namespace LabAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperComputer supercomputer = new SuperComputer();
            supercomputer.ModelNo = 567;
            supercomputer.ModelName = "SuperComputer";
            supercomputer.Year = 2000;

            Console.WriteLine(supercomputer.AboutComputer());
            Console.WriteLine(supercomputer.Movie());
            Console.WriteLine(supercomputer.Game());
            Console.ReadLine();

        }
    }
}
