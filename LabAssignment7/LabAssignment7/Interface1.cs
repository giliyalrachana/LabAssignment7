using System;

namespace LabAssignment7
{
    interface Interface1
    {
        static void Main()
        {
            Ibook book = new PhysicsBookcs();
            Console.WriteLine(book.StartWriting());
            Console.WriteLine(book.StopWriting());

        }
        
    }
}
