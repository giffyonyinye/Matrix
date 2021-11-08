using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public int DeterminateOfMatrix()

        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;
            int[,] numbers = new int[4, 4]
            {
                {3, 1, 2, 0 },
                {4, 4, 6, 1 },
                {2, 5, 7, 2 },
                {1, 8, 3, 7}
            };
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int k = 0; k < numbers.GetLength(1); k++)
                {
                   if (i == 0 && k == 0)
                    {
                        firstNumber = +numbers[i, k];
                        Console.WriteLine(firstNumber);

                        return firstNumber;
                    }
                    if (i == 1 && k == 1)
                    {
                        secondNumber = -numbers[i, k];
                        Console.WriteLine(secondNumber);
                        return secondNumber;
                    }
                    if (i == 2 && k == 2) {
                       thirdNumber = -numbers[i, k];
                        Console.WriteLine(thirdNumber);

                        return thirdNumber;
                    }
                    if (i == 3 && k == 3)
                    {
                        fourthNumber = -numbers[i, k];
                        Console.WriteLine(fourthNumber);

                        return fourthNumber;

                    }
                }
            }
            return 0;

        }

        public void MultiplyMatrix()
        {
            int[,] matrixA = new int[2,2] 
            {
                {2, 3 },
                {4, 5 },
            };

            int[,] matrixB = new int[2, 2]
            {
                {6,1 },
                {7, 3 },
            };
            var a = matrixA[0, 0] * matrixB[0,0] + matrixA[0,1] * matrixB[1,0];
            var b = matrixA[0,0] * matrixB[0,1] + matrixA[0, 1] * matrixB[1, 1];
            var c = matrixA[1, 0] * matrixB[0, 0] + matrixA[1, 1] * matrixB[1,0];
            var d = matrixA[1, 0] * matrixB[0, 1] + matrixA[1, 1] * matrixB[1,1];
            Console.WriteLine($"The result of multiply 2  matix is \n[{a} {b}] \n[{c} {d}]");   
        }
        
        public int Determinant(int[][] mat)
        {
            int rowNum = mat.Length;
            int colNum = mat[0].Length;

            if (rowNum != colNum)
            {
                Console.WriteLine("oops");
            }

            if (rowNum == 1 && colNum == 1)
            {
                return mat[0][0];
            }

            if (rowNum == 2 && colNum == 2)
            {
                int determinate;
                determinate = (mat[0][0] * mat[1][1] - (mat[0][1] * mat[1][0]));
                return determinate;
            }

            if (rowNum == 3 && colNum == 3)
            {
                int determinate;
                determinate = mat[0][0] * Determinant(GetMinor(0, 0, mat)) -
                mat[0][1] * Determinant(GetMinor(0, 1, mat)) +
                mat[0][2] * Determinant(GetMinor(0, 1, mat));
                return determinate;
            }

            int result = 0;
            for(int col = 0; col < colNum; col++)
            {
                if (col % 2 == 0)
                {
                    result += mat[0][col] * Determinant(GetMinor(0, col, mat));
                }
                else
                {
                    result += mat[0][col] * Determinant(GetMinor(0, col, mat));
                }
            }
            return result;
        }

        public int [][] GetMinor(int row, int col, int[][] mat)
        {
            int rowNum = mat.Length;
            int colNum = mat[0].Length;
            int[][] minor = new int[rowNum - 1][];
            int rowIndex = 0;

            for (int i = 0; i < rowNum; i++)
            {
                if (i == row)
                {
                    continue;
                }
                minor[rowIndex] = new int[colNum - 1];
                int colIndex = 0;
                for (int j = 0; j < colNum; j++)
                {
                    if ( j == col )
                    {
                        continue;
                    }
                    minor[rowIndex][colIndex] = mat[i][j];
                }
                ++rowIndex;
            }
            return minor;
        }
    }
}
