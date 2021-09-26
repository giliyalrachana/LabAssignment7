using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment7
{
    class Computer
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }

        public Computer()
        {
            Console.WriteLine("Default Constructor of computer");
        }
        // Overloaded Constructor
        public Computer(int modelNo,string modelName,int year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;
        }
        public string Movie()
        {
            return "Movie() from Computer";
        }
        public string Game()
        {
            return "Game() from Computer";
        }
        public string AboutComputer()
        {
            return $"Model No={this.ModelNo}\nModelName={this.ModelName}\nYear={this.Year}";
        }
    }
}
