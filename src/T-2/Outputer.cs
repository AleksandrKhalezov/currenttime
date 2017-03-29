using System;

namespace DEV_6
{
    public class Outputer
    {
        /// <summary>
        /// Outputing date and time in selected format
        /// </summary>
        public string DateOutputer(string key, string day, string mounth, string year, string hours, string minutes, string seconds)
        {
            string result = string.Empty;
            switch (key)
            {
                case "1":
                    result = day + "/" + mounth + "/" + year + " ";
                    break;
                case "2":
                    result = hours + ":" + minutes + ":" + seconds + " ";
                    break;
                case "3":
                   result = day + "/" + mounth + "/" + year + " " + hours + ":" + minutes + ":" + seconds + " ";
                    break;
                case "4":
                    result = mounth + "/" + day + "/" + year + " " + hours + ":" + minutes + " ";
                    break;

                default:
                    result = " Incorrect enter. Please try repeat : ";
                    break;
            }
            return result;
        }
    }
}
