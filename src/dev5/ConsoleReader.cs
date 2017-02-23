using System;
namespace DEV_5
{
    class ConsoleReader
    {
        public void InputMoney(string money)
        {
            Console.WriteLine("Enter the money:");          
            money = Console.ReadLine();            
        }

        public void InputProductivity(string productivity)
        {
            Console.WriteLine("Enter the productivity:");
            productivity = Console.ReadLine();
        }

        public void InputNumberOfCriterion(string numberOfCriterion)
        {
            Console.WriteLine("Enter the criterion: \n 1 / Maximum productivity to the amount \n 2 / The minimum cost for a fixed productivity \n 3 / The minimum number of personnel qualifications for higher Junior fixed          productivity");
            numberOfCriterion = Console.ReadLine();
        }

    }
}
