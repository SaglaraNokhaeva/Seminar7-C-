//Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.


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
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
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