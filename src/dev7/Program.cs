using System;

namespace DEV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            string inputLine = string.Empty;
            inputer.InputLine(inputLine);

            Outputer outputer = new Outputer();
            outputer.OutputAnswer();
 
            Console.ReadKey(true);
        }
    }
}
