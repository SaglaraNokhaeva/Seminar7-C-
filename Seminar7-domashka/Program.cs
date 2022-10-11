Console.Clear();
Console.WriteLine("Введите номер задачи (47, 50 или 52) для проверки:");
int num = int.Parse(Console.ReadLine());
if (num == 47) Task47();
else if (num == 50) Task50();
else if (num == 52) Task52();
else Console.WriteLine("Дополнительных задач не решала.");

void Task47()
{
    // Задача 47. Задайте двумерный массив размером m×n, 
    //заполненный случайными вещественными числами.
    //m = 3, n = 4.

    //0,5 7 -2 -0,2
    //1 -3,3 8 -9,9
    //8 7,8 -7,1 9


    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    double[,] array = FillArray(rowCount, columnCount);
    Console.WriteLine("Сформированный массив:");
    PrintArr(array);

    double[,] FillArray(int rows, int columns)
    {
        double[,] filledArray = new double[rows, columns];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = Math.Round(random.NextDouble() * 100, 1);
            }
        }
        return filledArray;
    };


    void PrintArr(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
};


void Task50()
{
    //Задача 50. Напишите программу, которая на вход принимает позиции 
    //элемента в двумерном массиве, и возвращает значение этого элемента 
    //или же указание, что такого элемента нет.

    //Например, задан массив:
    //1 4 7 2
    //5 9 2 3
    //8 4 2 4
    //17 -> такого числа в массиве нет


    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите  номер строки искомого элемента: ");
    int desiredRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца искомого элемента: ");
    int desiredСolumn = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    Console.WriteLine("Массив: ");
    PrintArr(array);
    if ((desiredRow <= rowCount - 1) && (desiredСolumn <= columnCount - 1))
        Console.WriteLine("Значение элемента: " + array[desiredRow, desiredСolumn]);
    else Console.WriteLine("Элемента с данными индексами в массиве нет.");

    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    };

    void PrintArr(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
};

void Task52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. 
    //Найдите среднее арифметическое элементов в каждом столбце.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    Console.WriteLine("Массив: ");
    PrintArr(array);

    for (int j = 0; j < columnCount; j++)
    {
        double summa = 0;
        for (int i = 0; i < rowCount; i++)
        {
            summa = summa + array[i, j];
        }
        double averageArif = summa / rowCount;
        Console.Write(Math.Round(averageArif, 2) + "; ");
    }

    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    };

    void PrintArr(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}