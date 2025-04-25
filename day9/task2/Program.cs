using System;
using MatrixApp;

class Program
{
    static void Main()
    {
        Matrix[] matrices = new Matrix[]
        {
            new Matrix(new double[,] {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            }),
            new Matrix(new double[,] {
                {1, 2},
                {3, 4}
            }),
            new Matrix(new double[,] {
                {0, 0},
                {0, 0}
            }),
            new Matrix(new double[,] {
                {5}
            }),
        };

        for (int i = 0; i < matrices.Length; i++)
        {
            Console.WriteLine($"Матрица {i + 1}:\n{matrices[i]}");

            Console.WriteLine($"Квадратная:           {matrices[i].IsSquare}");
            Console.WriteLine($"Нулевая:              {matrices[i].IsZero()}");
            Console.WriteLine($"Единичная:            {matrices[i].IsIdentity()}");
            Console.WriteLine($"Диагональная:         {matrices[i].IsDiagonal()}");
            Console.WriteLine($"Симметричная:         {matrices[i].IsSymmetric()}");
            Console.WriteLine($"Верхнетреугольная:    {matrices[i].IsUpperTriangular()}");
            Console.WriteLine($"Нижнетреугольная:     {matrices[i].IsLowerTriangular()}");
            Console.WriteLine();
        }

        Console.WriteLine("Сравнение матриц по сумме элементов:");
        for (int i = 0; i < matrices.Length - 1; i++)
        {
            int cmp = matrices[i].CompareTo(matrices[i + 1]);
            string relation = cmp == 0 ? "==" : (cmp < 0 ? "<" : ">");
            Console.WriteLine($"Матрица {i + 1} {relation} Матрица {i + 2}");
        }

        Console.WriteLine("\nСравнение на равенство:");
        Console.WriteLine($"Матрица 1 == Матрица 1: {matrices[0] == matrices[0]}");
        Console.WriteLine($"Матрица 1 == Матрица 2: {matrices[0] == matrices[1]}");
    }
}