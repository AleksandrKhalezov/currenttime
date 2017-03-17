using System;

namespace DEV_12
{
    /// <summary>
    /// Class of selection color
    /// </summary>
    public class ColorSelector
    {       
        public char SelectColor(string inputingColor)
        {
            if (string.Equals(inputingColor, "W") ||
                string.Equals(inputingColor, "w"))
            {
                return 'w';
            }
            else
            {
                if(string.Equals(inputingColor, "B") ||
                    string.Equals(inputingColor, "b"))
                {
                    return 'b';
                }
                else
                {
                    throw new FormatException (" Error! Wrong format of color! ");
                }
            }
        }       
    }
}
