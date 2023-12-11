using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sumMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsA, colsA, rowsB, colsB;
      // Запрашиваем у пользователя размеры мартиц
            Console.WriteLine("Введите количество строк первой матрицы:");
            int m1 = 0;
            if (!int.TryParse(Console.ReadLine(), out rowsA))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }

            Console.WriteLine("Введите количество столбцов первой матрицы:");
            int n1 = 0;
            if (!int.TryParse(Console.ReadLine(), out colsA))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }

            Console.WriteLine("Введите количество строк второй матрицы:");
            int m2 = 0;
            if (!int.TryParse(Console.ReadLine(), out rowsB))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }

            Console.WriteLine("Введите количество столбцов второй матрицы:");
            int n2 = 0;
            if (!int.TryParse(Console.ReadLine(), out colsB))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }

            if (colsA != colsB || rowsA != rowsB)
            {
                Console.WriteLine("Размеры матриц должны быть одинаковыми!");
                Console.ReadLine();
                return;
            }
            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsB, colsB];
            int[,] matrixC = new int[rowsA, colsA];
       // Создаются матрицы и заполняются рандомными числами
            
            Random randomA = new Random();
            Console.WriteLine("Первая матрица создана!");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    matrixA[i, j] = randomA.Next(1, 101);  // Случайные целые числа от 1 до 100
                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }
       // Сложение матриц      
            Random randomB = new Random();
            Console.WriteLine("Вторая матрица создана!");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
               {
                   matrixA[i, j] = randomA.Next(1, 101);  // Случайные целые числа от 1 до 100
                   Console.Write(matrixA[i, j] + " ");
               }
               Console.WriteLine();
           }
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
              
            }
            Console.WriteLine("Результат сложения матриц A и B: ");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write(matrixC[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
