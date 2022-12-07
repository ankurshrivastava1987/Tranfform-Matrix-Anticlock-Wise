using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16

            Console.WriteLine("enter number of row! ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("enter number of column!");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("enter matrix element!");
            string[] allElement = Console.ReadLine().ToString().Split(' ');
            int[,] matrix = new int[height, width];
            int k = 0;

            for (int row = 0; row < height; row++)
            {

                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = (int.Parse(allElement[k]));
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Prepared Matrix!");
            DisplayMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("enter number of rotation!");
            int rotation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Transformed Matrix!");
            TransformMatrixNtimesCounterClock(matrix, rotation);
        }

        static void TransformMatrixNtimesCounterClock(int[,] matrix, int rotation)
        {
            for (int rcount = 1; rcount <= rotation; rcount++)
            {
                AntiClockwiseMatrixTransform(matrix);
                if (rcount == rotation)
                    DisplayMatrix(matrix);
            }
        }


            /*
            int m;
            int n;
            int i;
            int j;
            var sc = "Inputs";
            Console.Write("Enter the number of rows: ");
            // taking row as input  
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            // taking column as input  
            n = Convert.ToInt32(Console.ReadLine());
            // Declaring the two-dimensional matrix   
            int[,] array = new int[m, n];
            // Read the matrix values   
            Console.WriteLine("Enter the elements of the array: ");
            // loop for row
            for (i = 0; i < m; i++)
            {
                // inner for loop for column
                for (j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine().ToString()
                        );
                }
            }
            // accessing array elements   
            Console.WriteLine("Elements of the array are: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    // prints the array elements  
                    Console.Write(array[i, j].ToString() + " ");
                }
                // throws the cursor to the next line  
                Console.WriteLine();
            }
            */

        /*
        Console.WriteLine("Enter the height: ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the width: ");
        int w = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[w, h];
        Console.Write("Enter a matrix : ");

        var numbers = new int[h, w];

        for (var i = 0; i < h; i++)
        {
            var numList = new string[h];
            numList = Console.ReadLine().Split();
            for (var j = 0; j < h; j++)
            {
                numbers[i, j] = Convert.ToInt32(numList[j]);
            }
        }


        DisplayMatrix(numbers);
        //var fooBarArray = Console.ReadLine().Split(new int[] { "[[", "], [", "]]" }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(x => x.Split(',').ToArray()).ToArray();
        //rotation = Convert.ToInt32(Console.ReadLine().ToString());
        //rotation = Convert.ToInt32(Console.ReadLine().ToString());
        Console.Write("Enter a matrix : ");

        //int[,] matrix1 = fooBarArray;

        Console.Write("Enter number of rotation anticlockwise : ");

        int rotation = 1;
        rotation = Convert.ToInt32( Console.ReadLine().ToString());

        int[,] matrix = {{ 1, 2, 3, 4 },{ 5, 6, 7, 8 },{ 9, 10, 11, 12 },{ 13, 14, 15, 16 }};

        //int rotation = 1024;
        //int[,] matrix = {
        //                    { 237, 682, 967, 921, 882, 164 },
        //                    { 361, 220, 607, 879, 560, 583 },
        //                    { 767, 488, 907, 314, 196, 599 },
        //                    { 129, 955, 499, 543, 722, 880 },
        //                    { 885, 102, 812, 556, 372, 838 },
        //                    { 921, 334, 705, 204, 425, 131 }
        //                };


        Console.WriteLine("Rotation Count : " + rotation.ToString());
        //test();
        //DisplayMatrix(matrix);


        //counterClockspiralPrint(4, 4, matrix);
        //for (int i = 1; i <= rotation; i++)
        //{
        //    //RotateMatrix(matrix);
        //    //if (i == rotation)
        //    //    PrintMatrix(matrix);

        //    AntiClockwiseMatrixTransform(matrix);
        //    if (i == rotation)
        //        DisplayMatrix(matrix);
        //}


        //int[,] matrix2 = { { 1,4},{5,8},{ 9,12},{ 13,16} };
        //PrintMatrix(matrix2);
        //RotateMatrix(matrix2);
        //PrintMatrix(matrix2);


        //Console.ReadLine();
        //Your code goes here
        //Console.WriteLine("Hello, world!");
        */




        static void AntiClockwiseMatrixTransform(int[,] matrix)
        {
            int maxRow = matrix.GetLength(0) - 1;
            int maxCol = matrix.GetLength(1) - 1;
            int row = 0;
            int col = 0;

            while (maxRow > row && col < maxCol)
            {

                int previous = matrix[maxRow - 1, col];
                //bottom row item change
                for (int i = col; i <= maxCol; i++)
                {
                    int current = matrix[maxRow, i];
                    matrix[maxRow, i] = previous;
                    previous = current;
                }
                maxRow--;

                //right most column item change
                for (int i = maxRow; i >= row; i--)
                {
                    int current = matrix[i, maxCol];
                    matrix[i, maxCol] = previous;
                    previous = current;
                }
               
                maxCol--;

                if (maxRow >= row)
                {
                    //top row item change
                    for (int i = maxCol; i >= col; i--)
                    {
                        int current = matrix[row, i];
                        matrix[row, i] = previous;
                        previous = current;
                    }
                    
                    row++;
                }

                if (col < maxCol + 1)
                {
                    //left column item change
                    for (int i = row; i <= maxRow; i++)
                    {
                        int current = matrix[i, col];
                        matrix[i, col] = previous;
                        previous = current;
                    }
                   
                    col++;
                }

            }
        }


        private static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        

       
    }
}
