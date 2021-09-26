using System;


namespace LabAssignment7
{
    class SuperComputer:Computer
    {
        public SuperComputer()
        {
            Console.WriteLine("Default constructor of SuperComputer");
        }
        public string MP3()
        {
            Console.WriteLine("MP3() in movie from SuperComputer");
        }
    }
}
