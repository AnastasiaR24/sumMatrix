﻿using System;
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
            Console.WriteLine("Введите количество строк для матриц:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матриц:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[rows, cols];
int[,] matrixB = new int[rows, cols];
int[,] matrixC = new int[rows, cols];

// Создаются матрицы и заполняются рандомными числами
Random random = new Random();
Console.WriteLine("Первая матрица создана!");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrixA[i, j] = random.Next(1, 101);  // Случайные целые числа от 1 до 100
        Console.Write(matrixA[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Вторая матрица создана!");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrixB[i, j] = random.Next(1, 101);  // Случайные целые числа от 1 до 100
        Console.Write(matrixB[i, j] + " ");
    }
    Console.WriteLine();
}
// Сложение матриц
 Console.WriteLine("Результат сложения матриц A и B: ");
 for (int i = 0; i < rows; i++)
 {
     for (int j = 0; j < cols; j++)
     {
         matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
         Console.Write(matrixC[i, j] + " ");
     }
     Console.WriteLine();
 }
Console.ReadLine();

        }
    }
}
