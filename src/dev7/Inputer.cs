using System;

namespace DEV_7
{
    class Inputer
    {
        //public void OutputLine(string outputLine)
        //{
        //    Inputer inputer = new DEV_7.Inputer();
        //    Console.WriteLine("Entering date and time ( in '23.02.2017 13:00' format) :");
        //    outputLine = inputer.InputLine(outputLine);
        //}

        public string InputLine(string line)//string line)
        {
            line = string.Empty;
            Console.WriteLine("Entering date and time ( in '23.02.2017 13:00' format) :");
            line = Console.ReadLine();
            return line;
        }
    }
}
