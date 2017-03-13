using System;

namespace DEV_6
{
    /// <summary>
    /// Enter point in programm.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            string currentDateString = string.Empty;
            string day = string.Empty;
            string mounth = string.Empty;
            string year = string.Empty;
            string hours = string.Empty;
            string minutes = string.Empty;
            string seconds = string.Empty;

            Inputer inputer = new Inputer();
            DateTime currentDate = new DateTime();
            currentDate = inputer.InputDate();  //Takeing the current time and date from the system.
            Console.WriteLine("The current date and time : " + currentDate);

            Converter converter = new Converter();  //Converting current time and date in string line.
            currentDateString = converter.ConvertDate(currentDate);

            Parser parser = new Parser();  //Parseng date line on different elements.
            day = parser.ParseDay(currentDateString);
            mounth = parser.ParseMounth(currentDateString);
            year = parser.ParseYear(currentDateString);
            hours = parser.ParseHours(currentDateString);
            minutes = parser.ParseMinutes(currentDateString);
            seconds = parser.ParseSeconds(currentDateString);

            Outputer outputer = new Outputer();  //Selecting type outputing on screen. 
            Console.WriteLine("Select output format : \n 1) Only date; \n 2) Only time; \n 3) Day/Mounth/Year Hours:Minutes:Seconds; \n 4) Mounth/Day/Year Hours:Minutes; \n Write 'exit' if you want to close programm");
            for (int i = 0; i <= 2; i++)
            {
                string key = string.Empty;
                key = Console.ReadLine();
                string result = string.Empty;
                if (key == "exit")
                {
                    i = 3;
                    break;
                }
                else
                {
                    i--;
                }
                result = outputer.DateOutputer(key, day, mounth, year, hours, minutes, seconds);  //Outputing on the screen.
                Console.WriteLine(result);
            }
            Console.ReadKey(true);
        }
    }
}
