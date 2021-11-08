using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = new int[][]
            {
                new int[] { 3, 1, 2, 0 },
                new int[] { 4, 4, 6, 1 },
                new int[] { 2, 5, 7, 2 },
                new int[] { 1, 8, 5, 7}
            };
            
            int[,] matrixA = new int[2, 2]
            {
                {2, 3 },
                {4, 5 },
            };

            int[,] matrixB = new int[2, 2]
            {
                {6,1 },
                {7, 3 },
            };
            var determinate = new Matrix();
            determinate.MultiplyMatrix(matrixA, matrixB);
            Console.WriteLine(determinate.Determinant(numbers));
            
        }
    }
}
