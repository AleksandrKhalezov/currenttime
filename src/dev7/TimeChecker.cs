using System;

namespace DEV_7
{
    class TimeChecker
    {
        public bool HoursChecker(bool answer)
        {
            ParserOfTime parserOfTime = new ParserOfTime();
            string hour = string.Empty;
            hour = parserOfTime.ParseHours(hour);

            answer = true;

            if ((char.IsDigit(hour[0]) == true) && char.IsDigit(hour[1]) == true)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            int line = Int32.Parse(hour);

            if ((answer == true) && (line > -1) && (line < 23))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool MinutesChecker(bool answer)
        {
            ParserOfTime parserOfTime = new ParserOfTime();
            string minute = string.Empty;
            minute = parserOfTime.ParseMinutes(minute);

            answer = true;

            if ((char.IsDigit(minute[0]) == true) && char.IsDigit(minute[1]) == true)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            int line = Int32.Parse(minute);

            if ((answer == true) && (line > -1) && (line < 60))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool ColonChecker(bool answer)
        {
            ParserOfTime parserOfTime = new ParserOfTime();
            string colon = string.Empty;
            colon = parserOfTime.ParseColon(colon);

            answer = true;

            if (colon == ":")
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool SpaceChecker(bool answer)
        {
            ParserOfTime parserOfTime = new ParserOfTime();
            string space = string.Empty;
            space = parserOfTime.ParseSpace(space);

            answer = true;

            if (space == " ")
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
