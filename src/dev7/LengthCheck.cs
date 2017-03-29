namespace DEV_7
{
    class LengthCheck
    {
        public bool LengthChecker(bool answer)
        {
            int lineLength = 15;

            string line = string.Empty;

            Converter converter = new Converter();
            line = converter.ConvertToString(line);

            if (line.Length == lineLength)
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
