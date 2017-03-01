namespace DEV_7
{
    class ParserOfTime
    {
        public string ParseHours(string timeLine)
        {
            timeLine = string.Empty;
            string hours = string.Empty;
            Converter converter = new Converter();
            timeLine = converter.ConvertToString(timeLine);
            if (timeLine == null)
            {
                return null;
            }
            else
            {
                hours = string.Concat(timeLine[11], timeLine[12]);
                return hours;
            }
        }
        public string ParseMinutes(string timeLine)
        {
            timeLine = string.Empty;
            string minutes = string.Empty;
            Converter converter = new Converter();
            timeLine = converter.ConvertToString(timeLine);
            if (timeLine == null)
            {
                return null;
            }
            else
            {
                minutes = string.Concat(timeLine[14], timeLine[15]);
                return minutes;
            }
        }
        public string ParseColon(string timeLine)
        {
            timeLine = string.Empty;
            string colon = string.Empty;
            Converter converter = new Converter();
            timeLine = converter.ConvertToString(timeLine);
            if (timeLine == null)
            {
                return null;
            }
            else
            {
                colon = string.Concat(timeLine[13]);
                return colon;
            }
        }
        public string ParseSpace(string timeLine)
        {
            timeLine = string.Empty;
            string space = string.Empty;
            Converter converter = new Converter();
            timeLine = converter.ConvertToString(timeLine);
            if (timeLine == null)
            {
                return null;
            }
            else
            {
                space = string.Concat(timeLine[10]);
                return space;
            }
        }
    }
}
