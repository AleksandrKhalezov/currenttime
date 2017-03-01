using System;

namespace DEV_7
{
    class Outputer
    {
        public void OutputAnswer()
        {
            bool answer = true;
            AnswersFromCheckers answersFromChecker = new AnswersFromCheckers();
            answer = answersFromChecker.CombiningAllAnswers(answer);
            if (answer == true)
            {
                Console.WriteLine("Time and date is valid. Format is right");
            }
            else
            {
                Console.WriteLine("Time and date is not valid. Format is not right. /n Please enter valid time in specified format.");
            }
        }
    }
}
