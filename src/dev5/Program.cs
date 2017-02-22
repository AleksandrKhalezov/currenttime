using System;
namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = string.Empty;
            string p = string.Empty;
            string n = string.Empty;
            ConsoleReader reader = new ConsoleReader();
            reader.InputMoney(m);           
            reader.InputProductivity(p);
            reader.InputNumberOfCriterion(n);
            Console.ReadKey(true);

        }
    }
}
