// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
int Factorial (int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
        result *= i;

    return result;
}

void FillArray(int[,] array, int N)
{
    array[0, 0] = 1;
    for (int i = 1; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Factorial(i) / (Factorial(j) * Factorial(i - j));
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - i); j++)
            Console.Write(" ");
        for (int k = 0; k < (array.GetLength(0)); k++)
        {
            if (array[i, k] == 0)
                Console.Write(" ");
            else
                Console.Write($" {array[i, k]}");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк треугольника Паскаля");
int N = int.Parse(Console.ReadLine()?? "0");
int [,] array = new int [N,N];
FillArray(array, N);
Console.WriteLine();
PrintArray (array);
