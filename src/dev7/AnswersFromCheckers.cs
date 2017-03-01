namespace DEV_7
{
    class AnswersFromCheckers
    {
        public bool CombiningAllAnswers(bool mainAnswer)
        {
            bool day = true;
            bool mounth = true;
            bool year = true;
            bool point = true;
            bool space = true;
            bool hour = true;
            bool minute = true;
            bool colon = true;
            bool lineLength = true;

            bool timeAnswer = true;
            bool dateAnswer = true;

            DateChecker dateChecker = new DateChecker();
            TimeChecker timeChecker = new TimeChecker();

            day = dateChecker.DaysChecker(day);
            mounth = dateChecker.MounthsChecker(mounth);
            year = dateChecker.YearsChecker(year);
            point = dateChecker.PointChecker(point);

            space = timeChecker.SpaceChecker(space);
            hour = timeChecker.HoursChecker(hour);
            minute = timeChecker.MinutesChecker(minute);
            colon = timeChecker.ColonChecker(colon);

           


            if ((day == true) && (mounth == true) && (year == true) && (point == true))
            {
                dateAnswer = true;
            } 
            else
            {
                dateAnswer = false;
            }

            if ((space == true) && (hour == true) && (colon == true) && (minute == true) && (lineLength == true))
            {
                timeAnswer = true;
            }
            else
            {
                timeAnswer = false;
            }

            if ((timeAnswer == true) && (dateAnswer == true))
            {
                mainAnswer = true;
            }
            else
            {
                mainAnswer = false;
            }

            return mainAnswer;
        }
    }
}
