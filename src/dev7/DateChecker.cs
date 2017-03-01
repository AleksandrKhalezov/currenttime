using System;

namespace DEV_7
{
    class DateChecker
    {
        public bool DaysChecker( bool answer)
        {
            ParserOfDate parserOfDate = new ParserOfDate();
            string day = string.Empty;
            day = parserOfDate.ParseDays(day);

            answer = true;

            if ((char.IsDigit(day[0]) == true) && char.IsDigit(day[1]) == true )
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            int line = Int32.Parse(day);

            if (( answer == true ) && ( line > 0 ) && ( line < 32 ))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool MounthsChecker(bool answer)
        {
            ParserOfDate parserOfDate = new ParserOfDate();
            string mounth = string.Empty;
            mounth = parserOfDate.ParseMounths(mounth);

            answer = true;

            if ((char.IsDigit(mounth[0]) == true) && char.IsDigit(mounth[1]) == true)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            int line = Int32.Parse(mounth);

            if ((answer == true) && (line > 0) && (line < 13))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool YearsChecker(bool answer)
        {
            ParserOfDate parserOfDate = new ParserOfDate();
            string year = string.Empty;
            year = parserOfDate.ParseMounths(year);

            answer = true;

            if ((char.IsDigit(year[0]) == true) && char.IsDigit(year[1]) == true)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            int line = Int32.Parse(year);

            if ((answer == true) && (line > 1970) && (line < 2050))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool PointChecker(bool answer)
        {
            ParserOfDate parserOfDate = new ParserOfDate();
            string point = string.Empty;
            point = parserOfDate.ParsePoint(point);

            answer = true;

            if ((point == ".."))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }
    }
}
