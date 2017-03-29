namespace DEV_7
{
    class Converter
    {
        public string ConvertToString( string newLine )
        {
            newLine = string.Empty;
            Inputer inputer = new Inputer();
            newLine = inputer.InputLine(newLine);
            newLine.ToString();
            if (newLine.Length != 15)
            {
                return null;
            }
            else
            {
                return newLine;
            }          
        }
    }
}
