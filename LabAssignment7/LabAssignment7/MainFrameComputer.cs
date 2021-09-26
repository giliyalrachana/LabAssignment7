using System;


namespace LabAssignment7
{
    class MainFrameComputer:SuperComputer
    {
        public MainFrameComputer()
        {
            Console.WriteLine("Default constructor of MainFrameComputer");
        }
        public string MP4()
        {
            return "MP4() in Movie from MainFrameComputer";
        }

    }
}
