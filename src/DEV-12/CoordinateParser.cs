using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DEV_12
{
    public class CoordinateParser
    {
        /// <summary>
        /// Class parsing inputing coordinates
        /// </summary>
        /// <param name="inputingCoordinate"></param>
        /// <returns></returns>
        public int[] SelectCoordinate(string inputingCoordinate)
        {
            inputingCoordinate = inputingCoordinate.ToLower();
            string coordinatePattern = @"^\s*[abcdefgh]\s*[12345678]\s*$";
            if (Regex.IsMatch(inputingCoordinate, coordinatePattern))
            {
                inputingCoordinate = inputingCoordinate.Trim();
                if ((inputingCoordinate.First() - 96) % 2 == inputingCoordinate.Last() % 2)
                {
                    int[] newCoordinate = new int[2];
                    return newCoordinate = new int[2] {( inputingCoordinate.First() - 96), (inputingCoordinate.Last() - 48)};
                }
                else
                {
                    throw new FormatException(" Error! By rules only black fields are allowed! ");
                }
            }
            else
            {
                throw new FormatException(" Error! Wrong format of coordinates! ");
            }
        }
    }
}