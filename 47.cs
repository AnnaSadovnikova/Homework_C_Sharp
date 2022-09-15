
void Zadacha47()
{
    // Zadacha 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
}

Zadacha47();

static void FillArray(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Vivod massiva");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
