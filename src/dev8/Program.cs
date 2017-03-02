using System;

namespace DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            InputMatrix inputMatrix = new InputMatrix();
            MatrixMultyply matrixMultiply = new MatrixMultyply();

            Console.WriteLine("First matrix");
            double[,] firstMatrix = inputMatrix.inputMatrix();

            Console.WriteLine("Second matrix");
            double[,] secondMatrix = inputMatrix.inputMatrix();

            double[,] resultMatrix = matrixMultiply.DoMatrixMultyply(firstMatrix,secondMatrix);

            if (resultMatrix == null)
            {
                Console.WriteLine("We can't multiply they!");
            }
            else
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        Console.WriteLine(resultMatrix[i, j] + "    ");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
