using System;

namespace DEV_8
{
    class InputMatrix
    {
        public double [,] inputMatrix()
        {
            int a, b;

            Console.WriteLine("Enter number of lines in matrix:");
            a = EnterCorrectInt();

            Console.WriteLine("Enter number of column in matrix:");
            b = EnterCorrectInt();

            double[,] matrix = new double [a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("Enter the [" + i + "][" + j + "] element");
                    matrix[i, j] = EnterCorrectDouble();
                    Console.Write("\n", matrix[i, j]);
                }
            }
            return matrix;
        }

        public int EnterCorrectInt()
        {
            int number = 0;
            string numb = string.Empty;
            while (true)
            {
                numb = Console.ReadLine();
                try
                {
                    number = Int32.Parse(numb);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad Format. \n Enter correct integer number", numb);
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow. \n Enter correct integer number", numb);
                    continue;
                }
            }
            return number;
        }

        public double EnterCorrectDouble()
        {
            double number = 0.0;
            string numb = string.Empty;
            while(true)
            {
                numb = Console.ReadLine();
                try
                {
                    number = Double.Parse(numb);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad Format. \n Enter correct double number", numb);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow. \n Enter correct double number", numb);
                    break;
                }
            }
            return number;
        }
    }
}
