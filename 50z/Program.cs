void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

void SearchMatrix(int[,] matrix)
{
    Console.WriteLine("Введите позицию элемента: ");
    int[] search = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    if(search[0] >= matrix.GetLength(0) || search[1] >= matrix.GetLength(1))
        Console.WriteLine("Такой позиции нет в матрице");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == search[0] && j == search[1])
                Console.WriteLine(matrix[i, j]);
        }
    }
}

Console.Clear();
int[,] matrix = new int[5, 5];
Console.WriteLine($"Матрица: ");
InputMatrix(matrix);
SearchMatrix(matrix);