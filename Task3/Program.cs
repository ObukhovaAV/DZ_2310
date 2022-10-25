// Сформировать трехмерный массив не повторяющимися двузначными числами,
// показать его построчно на экран выводя индексы соответствующего элемента
void FillArray (int[,,] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(2); k++)
           array [i,j,k] = random.Next (min,max);
 
}
void PrintArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(2); k++) 
           Console.Write($"{array [i,j,k]} {(i,j,k)}   ");
    Console.WriteLine();
    }
}
int [,,] array = new int [2,2,2];
FillArray (array, 10,99);
Console.WriteLine("Your 3D array: ");3  
PrintArray (array);