using System;

namespace DEV_12
{
    /// <summary>
    /// Entry point in program
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter color of checker(b/w):");
                ColorSelector colorSelector = new ColorSelector();
                char colorOfChecker = colorSelector.SelectColor(Console.ReadLine());

                CoordinateParser coordinateSelector = new CoordinateParser();

                int[] startCoordinate = new int[2];
                Console.WriteLine("Enter start coordinate of checker.For example 'a1, ... h8': ");
                startCoordinate  = coordinateSelector.SelectCoordinate(Console.ReadLine());

                int[] finishCoordinate = new int[2];
                Console.WriteLine("Enter finish coordinate of checker.For example 'a1, ... h8': ");
                finishCoordinate = coordinateSelector.SelectCoordinate(Console.ReadLine());

                StepsChecker stepsChecker = new StepsChecker();
                Console.WriteLine(stepsChecker.Count(colorOfChecker, startCoordinate, finishCoordinate));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
