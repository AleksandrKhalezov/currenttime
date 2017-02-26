using System;

namespace DEV_6
{
    class InputDate
    {
        /// <summary>
        /// Entering date and time.
        /// And converter to string
        /// </summary>
        /// <param name="datestring"></param>
        /// <returns></returns>
        public string DateInputer(string datestring)
        {
            datestring = string.Empty;
            DateTime date = DateTime.Now;            
            datestring = date.ToString();
            return datestring;
        }

    }
}
