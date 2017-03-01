namespace DEV_7
{
    class ParserOfDate
    {
        public string ParseDays(string dateLine)
        {
            dateLine = string.Empty;
            string days = string.Empty;
            Converter converter = new Converter();
            dateLine = converter.ConvertToString(dateLine);
            if (dateLine == null)
            {
                return null;
            }
            else
            {
                days = string.Concat(dateLine[1], dateLine[2]);
                return days;
            }
        }

        public string ParseMounths(string dateLine)
        {
            dateLine = string.Empty;
            string mounths = string.Empty;
            Converter converter = new Converter();
            dateLine = converter.ConvertToString(dateLine);
            if (dateLine == null)
            {
                return null;
            }
            else
            {
                mounths = string.Concat(dateLine[3], dateLine[4]);
                return mounths;
            }
        }
        public string ParseYears(string dateLine)
        {
            dateLine = string.Empty;
            string years = string.Empty;
            Converter converter = new Converter();
            dateLine = converter.ConvertToString(dateLine);
            if (dateLine == null)
            {
                return null;
            }
            else
            {
                years = string.Concat(dateLine[6], dateLine[7], dateLine[8], dateLine[8]);
                return years;
            }
        }
        public string ParsePoint(string dateLine)
        {
            dateLine = string.Empty;
            string point = string.Empty;
            Converter converter = new Converter();
            dateLine = converter.ConvertToString(dateLine);
            if (dateLine == null)
            {
                return null;
            }
            else
            {
                point = string.Concat(dateLine[2], dateLine[5]);
                return point;
            }
        }
    }
}
