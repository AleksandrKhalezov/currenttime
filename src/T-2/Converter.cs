using System;

namespace DEV_6
{
    public class Converter
    {
        /// <summary>
        /// Convert dateline to string format
        /// </summary>
        /// <param name="dateLine"></param>
        /// <returns></returns>
        public string ConvertDate(DateTime dateLine)
        {
            string date = dateLine.ToString();
            return date;
        }
    }
}
