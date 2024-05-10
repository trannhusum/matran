using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix(3, 3); 
            FindMaxElement(matrix);

           
            Console.WriteLine("Nhap kich thuoc cua ma tran:");
            Console.Write("So cot: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("So hang: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] userMatrix = GetUserMatrix(rows, columns);
            FindMaxElement(userMatrix);
            Console.ReadKey();
        }
        static int[,] GenerateMatrix(int rows, int columns)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
            return matrix;
        }

        
        static void FindMaxElement(int[,] matrix)
        {
            int max = int.MinValue;
            int maxRow = 0;
            int maxColumn = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxRow = i;
                        maxColumn = j;
                    }
                }
            }

            Console.WriteLine("Gia tri lon nhat "+max+", Tai hang "+(maxRow+1)+", cot "+ (maxColumn+1));
        }

        
        static int[,] GetUserMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Nhap gia tri tai"+ "[{"+i+ "},{"+ j+"}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
    }
}
