using System;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        void fileFinder()
        {
            var foundFiles, aFile;
            foundFiles = aqFileSystem["FindFiles"]("C:\\Work\\", "*.exe");
            if(foundFiles != null)
            {
                while(foundFiles["HasNext"]())
                {
                    aFile = foundFiles["Next"]();
                    Log["Message"](aFile["Name"]);
                }
            } else
            {
                Log["Message"]("No FIles were found.");
            }
        }
    }
}
