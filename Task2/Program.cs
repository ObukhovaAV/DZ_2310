// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillMatrix(int[,] matrix, int min,int max)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
    matrix[i,j] = random.Next(min,max);    
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
int [] FindPositionMinArray(int[,] matrix)
{
   int min = matrix[0, 0];
   int a = 0;
   int b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j<matrix.GetLength(1); j++)  
            if (matrix[i, j] < min)  
            {
                min = matrix [i,j];
                a = i;
                b = j;
            }
    return new int [] {a,b};
            
}
Console.WriteLine ("Задайте размер массива mxn");
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("Введите n");
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [m,n];
FillMatrix (matrix, -20, 20);
Console.WriteLine();
PrintMatrix (matrix);
Console.WriteLine();
int [] position = FindPositionMinArray (matrix);
Console.Write($"Минимальный элемент находится в {position[0]+1} строке и  {position[1]+1} столбце");
Console.WriteLine();
Console.WriteLine ($"Массив после удаления {position[0]+1} строки и  {position[1]+1} столбца ");
for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i==position[0] || j==position[1])
        Console.Write(" "); 
        else       
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
   }


    


    





