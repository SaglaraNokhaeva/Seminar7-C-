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

double [,] array = FillArray(array);
PrintArr(array);

double[,] FillArray(double[,] arrayLocal)
{
    double[,] filledArray = new double[rowCount, columnCount];
    Random rnd =new Random();
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            filledArray[i, j] = rnd.NextDouble();
        }
    }
    return filledArray;
};

void PrintArr(double [,] inputArray){
   for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int  j = 0; j < inputArray.GetLength(1); j++)
        {
           Console.Write(" "+inputArray[i,j]); 
        }
        Console.WriteLine();
    } 
}