using System;


namespace LabAssignment7
{
    class Room
    {
        public int Number { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public DateTime BookedTime { get; set; }
        public double Price { get; set; }
        public Room()
        {
            Console.WriteLine("Default constructor of Room");
        }
        public Room(int number, int floor, string type, int capacity, DateTime bookedTime, double price)
        {
            this.Number = number;
            this.Floor = floor;
            this.Type = type;
            this.Capacity = capacity;
            this.BookedTime = bookedTime;
            this.Price = price;
        }
        // Copy constructor
        public Room(Room room)
        {
            this.Number = room.Number;
            this.Floor = room.Floor;
            this.Type = room.Type;
            this.Capacity = room.Capacity;
            this.BookedTime = room.BookedTime;
            this.Price = room.Price;

        }
        



    }
}
