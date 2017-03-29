namespace DEV_6
{
    /// <summary>
    /// Parse string of data on different parts.
    /// </summary>
    public class Parser
    {
        string day = string.Empty;
        string mounth = string.Empty;
        string year = string.Empty;
        string hours = string.Empty;
        string minutes = string.Empty;
        string seconds = string.Empty;

        public string ParseDay( string line)
        {
            day = string.Concat( line[0], line[1]);
            return day;
        }

        public string ParseMounth(string line)
        {
            mounth = string.Concat(line[3], line[4]);
            return mounth;
        }

        public string ParseYear(string line)
        {
            year = string.Concat(line[6], line[7], line[8], line[9]);
            return year;
        }

        public string ParseHours(string line)
        {
            hours = string.Concat(line[11], line[12]);
            return hours;
        }

        public string ParseMinutes(string line)
        {
            minutes = string.Concat(line[14], line[15]);
            return minutes;
        }

        public string ParseSeconds(string line)
        {
            seconds = string.Concat(line[17], line[18]);
            return seconds;
        }
    }
}
