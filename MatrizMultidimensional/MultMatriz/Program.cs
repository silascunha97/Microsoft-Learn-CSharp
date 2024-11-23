// See https://aka.ms/new-console-template for more information
//int[] matriz1 = int new[2,3]{};
//int[] matriz2 = int new[3,2]{};
//int[] result = int new[2,2];
//
//
//Console.WriteLine("Preencha a primeira Matriz #1 ");
//for (int linha = 0; linha < 2; linha++)
//{
//    for (int coluna = 0; coluna < 3; coluna++)
//    {
//        Console.Write($"Matriz #1 {linha} e {coluna}");
//        matriz1[linha, coluna] = int.Parse(Console.ReadLine());
//    };
//};
//Console.WriteLine("Preencha a primeira Matriz #2 ");
//
//for (int linha = 0; linha < 3; linha++)
//{
//    for (int coluna = 0; coluna < 2; coluna++)
//    {
//        Console.Write($"Matriz #1 {linha} e {coluna}");
//        matriz2[linha, coluna] = int.Parse(Console.ReadLine());
//    };
//};
//
//Console.WriteLine("\n Resultado de matriz #1 X matriz #2 ");
//result[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
//result[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
//result[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
//result[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);
//
//Console.WriteLine($"[  {result[0, 0]} ] [ {result[0, 1]} ] \n");
//Console.WriteLine($"[  {result[1, 0]}  ] [  {result[1, 1]} ]");

using System;

namespace MatrizMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração correta de matrizes bidimensionais
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] result = new int[2, 2];

            // Leitura dos valores das matrizes
            Console.WriteLine("Preencha a primeira Matriz #1 ");
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Matriz #1 [{linha},{coluna}]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Preencha a primeira Matriz #2 ");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write($"Matriz #2 [{linha},{coluna}]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            // Cálculo da multiplicação das matrizes
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matriz1.GetLength(1); k++)
                    {
                        result[i, j] += matriz1[i, k] * matriz2[k, j];
                    }
                }
            }

            // Impressão do resultado
            Console.WriteLine("\n Resultado da matriz #1 X matriz #2 ");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
