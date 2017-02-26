using System;

namespace DEV_6
{
    class OutputDate
    {
        string dateAndTime = string.Empty;
        string d = string.Empty;
        string m = string.Empty;
        string y = string.Empty;
        string hour = string.Empty;
        string min = string.Empty;
        string sec = string.Empty;

        /// <summary>
        /// Outputing date and time in selected format
        /// </summary>
        public void DateOutputer()
        {
            string key = string.Empty;
            Parser parser = new Parser();
            Console.WriteLine("Select output format : \n 1) Only date; \n 2) Only time; \n 3) Day/Mounth/Year Hours:Minutes:Seconds; \n 4) Mounth/Day/Year Hours:Minutes; \n Write 'exit' if you want to close programm");


            d = parser.ParseDay(d);
            m = parser.ParseMounth(m);
            y = parser.ParseYear(y);
            hour = parser.ParseHours(hour);
            min = parser.ParseMinutes(min);
            sec = parser.ParseSeconds(sec);

            for (int i = 0; i <= 10; i++)
            {
                key = Console.ReadLine();
                if (key == "1")
                {
                    Console.WriteLine(d + "/" + m + "/" + y + " ");
                }
                else
                {
                    if (key == "2")
                    {
                        Console.WriteLine(hour + ":" + min + ":" + sec + " ");
                    }
                    else
                    {
                        if (key == "3")
                        {
                            Console.WriteLine(d + "/" + m + "/" + y + " " + hour + ":" + min + ":" + sec + " ");
                        }
                        else
                        {
                            if (key == "4")
                            {
                                Console.WriteLine(m + "/" + d + "/" + y + " " + hour + ":" + min + " ");
                            }
                            else
                            {
                                if (key == "exit")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(" Incorrect enter. Please try repeat : ");
                                    continue;
                                }
                            }
                        }
                    }
                }                      
            }
        }
    }
}
