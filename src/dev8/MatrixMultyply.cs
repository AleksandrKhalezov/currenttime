using System;

namespace DEV_8
{
    class MatrixMultyply
    {
        private bool PossibilityOfMultiplicationTest(double[,] firstMatrix, double[,] secondMatrix)
        {
            int linesOne = firstMatrix.GetLength(0);
            int columnsOne = firstMatrix.GetLength(1);
            int linesTwo = secondMatrix.GetLength(0);
            int columnsTwo = secondMatrix.GetLength(1);

            bool answer = true;

            if (columnsOne != linesTwo)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            return answer;
        }

        public double[,] DoMatrixMultyply(double[,] firstMatrix, double[,] secondMatrix)
        {
            int linesOne = firstMatrix.Length;
            int columnsOne = firstMatrix.GetLength(1);
            int linesTwo = secondMatrix.Length;
            int columnsTwo = secondMatrix.GetLength(1);
            bool answer;
            answer = PossibilityOfMultiplicationTest(firstMatrix, secondMatrix);
            double[,] resultMatrix = new double[linesOne, columnsTwo];
            if (answer)
            {
                for (int i = 0; i < linesOne; i++)
                {                                          
                    for (int j = 0; j < columnsTwo; j++)
                    {
                        resultMatrix[i, j] = 0;
                        for (int k = 0; k < columnsOne; k++)
                        {
                            try
                            {
                                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                            }
                            catch(IndexOutOfRangeException)
                            {
                                Console.WriteLine("IndexOutOfRangeException is catched");
                                break;                                
                            }
                        }
                    }
                }
                return resultMatrix;                                               
            }
            else
            {
                return null;
            }            
        }
    }
}
