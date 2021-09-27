using System;

namespace LabAssignment7
{
    public abstract class AbstractComputer
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public string Year { get; set; }
        public AbstractComputer(int modelNo, string modelName, string year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;
        }
        public string AboutAbstractComputer()
        {
            return $"Model No={this.ModelNo}\nName={this.ModelName}\nYear={this.Year}";
        }
        public string BootUp()
        {
            return "BootUp() calling from AbstractComputer";
        }
        public string ShutDown()
        {
            return "ShutDown() calling from AbstractComputer";
        }
    }
    class Laptop : AbstractComputer
    {
        public Laptop(int modelNo,string modelName, string year) : base(modelNo,modelName, year)
        {

        }
        public string Letters(int noOfLetters)
        {
            return $"This is {noOfLetters} Laptop";
        }
    }
  

    
}
