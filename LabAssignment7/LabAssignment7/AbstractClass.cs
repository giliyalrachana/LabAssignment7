using System;


namespace LabAssignment7
{
    // This program demo. how to use abstract class
    class AbstractClass
    {
        static void Main()
        {
            Laptop mac = new Laptop(122,"hp","1995");
            Console.WriteLine(mac.AboutAbstractComputer());
            Console.WriteLine(mac.BootUp());
            Console.WriteLine(mac.ShutDown());
            Console.ReadLine();



        }
    }
}
