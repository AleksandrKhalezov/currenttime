using System;

namespace DEV_6
{
    /// <summary>
    /// Enter point in programm.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Empty;
            InputDate input = new InputDate();
            a = input.DateInputer(a);
            Console.WriteLine("The current date and time : " + a);

            OutputDate output = new OutputDate();
            output.DateOutputer();

            Console.ReadKey(true);
        }
    }
}
