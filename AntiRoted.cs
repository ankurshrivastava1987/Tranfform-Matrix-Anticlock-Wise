using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    class AntiRoted
    {

         static void RotateMatrix(int[,] matrix)
        {
            int maxRow = matrix.GetLength(0) - 1;
            int maxCol = matrix.GetLength(1) - 1;
            int row = 0;
            int col = 0;

            while (row < maxRow && col < maxCol)
            {

                int previous = matrix[row + 1, col];

                //Top Row element change
                for (int i = col; i <= maxCol; i++)
                {
                    int current = matrix[row, i];
                    matrix[row, i] = previous;
                    previous = current;
                }
                row++;

                //for all rows, Last Column Item changed
                for (int i = row; i <= maxRow; i++)
                {
                    int current = matrix[i, maxCol];
                    matrix[i, maxCol] = previous;
                    previous = current;
                }
                maxCol--;

                if (row < maxRow + 1)
                {
                    //bottom row item changed
                    for (int i = maxCol; i >= col; i--)
                    {
                        int current = matrix[maxRow, i];
                        matrix[maxRow, i] = previous;
                        previous = current;
                    }
                    maxRow--;
                }

                if (col < maxCol + 1)
                {
                    //most left column item replace, (First column)
                    for (int i = maxRow; i >= row; i--)
                    {
                        int current = matrix[i, col];
                        matrix[i, col] = previous;
                        previous = current;
                    }
                    col++;
                }
            }
        }



        // function to print the required traversal
        static void counterClockspiralPrint(int m,
                                            int n,
                                            int[,] arr)
        {
            int i, k = 0, l = 0;

            // k - starting row index
            // m - ending row index
            // l - starting column index
            // n - ending column index
            // i - iterator

            // initialize the count
            int cnt = 0;

            // total number of elements in matrix
            int total = m * n;

            while (k < m && l < n)
            {
                if (cnt == total)
                    break;

                // Print the first column from
                // the remaining columns
                for (i = k; i < m; ++i)
                {
                    Console.Write(arr[i, l] + " ");
                    cnt++;
                }
                l++;

                if (cnt == total)
                    break;

                // Print the last row from
                // the remaining rows
                for (i = l; i < n; ++i)
                {
                    Console.Write(arr[m - 1, i] + " ");
                    cnt++;
                }
                m--;

                if (cnt == total)
                    break;

                // Print the last column from
                // the remaining columns
                if (k < m)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.Write(arr[i, n - 1] + " ");
                        cnt++;
                    }
                    n--;
                }

                if (cnt == total)
                    break;

                // Print the first row from
                // the remaining rows
                if (l < n)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.Write(arr[k, i] + " ");
                        cnt++;
                    }
                    k++;
                }
            }
        }


        static void RotateMatrixAntiClockwise1(int[,] matrix)
        {
            int maxRow = matrix.GetLength(0) - 1;
            int maxCol = matrix.GetLength(1) - 1;
            int row = 0;
            int col = 0;

            while (row < maxRow && col < maxCol)
            {
                int previous = matrix[row, col + 1];
                for (int i = col; i <= maxCol; i++)
                {
                    int current = matrix[row, i];
                    matrix[row, i] = previous;
                    previous = current;
                }
                row++;

                for (int i = row; i <= maxRow; i++)
                {
                    int current = matrix[i, maxCol];
                    matrix[i, maxCol] = previous;
                    previous = current;
                }
                maxCol--;


                if (col < maxCol + 1)
                {
                    for (int i = maxCol; i >= col; i--)
                    {
                        int current = matrix[i, row];
                        matrix[i, row] = previous;
                        previous = current;
                    }
                    col++;
                }



                if (row < maxRow + 1)
                {
                    for (int i = maxRow; i >= row; i--)
                    {
                        int current = matrix[maxCol, i];
                        matrix[maxCol, i] = previous;
                        previous = current;
                    }
                    maxRow--;
                }


            }
        }


        static void RotateMatrix1(int[,] matrix)
        {
            int maxRow = matrix.GetLength(0) - 1;
            int maxCol = matrix.GetLength(1) - 1;
            int row = 0;
            int col = 0;

            while (row < maxRow && col < maxCol)
            {

                int previous = matrix[row + 1, col];
                for (int i = col; i <= maxCol; i++)
                {
                    int current = matrix[row, i];
                    matrix[row, i] = previous;
                    previous = current;
                }
                row++;

                for (int i = row; i <= maxRow; i++)
                {
                    int current = matrix[i, maxCol];
                    matrix[i, maxCol] = previous;
                    previous = current;
                }
                maxCol--;

                if (row < maxRow + 1)
                {
                    for (int i = maxCol; i >= col; i--)
                    {
                        int current = matrix[maxRow, i];
                        matrix[maxRow, i] = previous;
                        previous = current;
                    }
                    maxRow--;
                }

                if (col < maxCol + 1)
                {
                    for (int i = maxRow; i >= row; i--)
                    {
                        int current = matrix[i, col];
                        matrix[i, col] = previous;
                        previous = current;
                    }
                    col++;
                }
            }
        }


    }
}
// This code is contri

