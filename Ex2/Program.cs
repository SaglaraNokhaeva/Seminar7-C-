﻿//Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

Console.Clear();
Console.Write("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int [,] array = FillArray(rowCount, columnCount, 1, 10);
PrintArr(array);

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];
    for (int i = 0; i < columns; i++)
    {
        for (int  j = 0; j < rows; j++)
        {
            filledArray[i, j] = i+j;
        }
    }
    return filledArray;
};

void PrintArr(int [,] inputArray){
   for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int  j = 0; j < inputArray.GetLength(1); j++)
        {
           Console.Write(" "+inputArray[i,j]); 
        }
        Console.WriteLine();
    } 
}