using System;


namespace LabAssignment7
{
    class ConstructorDemo
    {
        static void Main()
        {
            Room room1 = new Room("number", "floor", "type", "capacity", "bookedTime", "price");
            Room room2 = new Room(room1);
            Console.WriteLine($"Number={ room2.Number}\n Floor={ room2.Floor}\n Type= {room2.Type}\n Capacity={ room2.Capacity}\n BookedTime= { room2.BookedTime }\n Price= { room2.Price }" );
            Console.ReadLine();
        }
            
    }
}
