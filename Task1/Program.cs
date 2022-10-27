// Найти произведение двух матриц
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
int [,] ProductMatrices (int[,] A, int[,] B)
{
    int [,] C = new int [A.GetLength(0), B.GetLength(1)];   
 
        for (int i = 0; i < C.GetLength(0); i++)          
            for (int j = 0; j < C.GetLength(1); j++)            
                for (int k = 0; k < A.GetLength(1); k++)
                    C[i,j] = C[i,j]+A[i,k]*B[k,j];
            
    return C;
}

Console.WriteLine("Задайте размер матрицы №1 mxn");
Console.WriteLine("Введите m");
int m = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Введите n");
int n = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Задайте размер матрицы №2 pxq");
Console.WriteLine("Введите p");
int p = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Введите q");
int q = int.Parse (Console.ReadLine() ?? "0");
int [,] A = new int[m,n];
int [,] B = new int [p,q];


FillMatrix(A, 1,10);
Console.WriteLine("Матрица №1:");
PrintMatrix(A);
Console.WriteLine();
FillMatrix(B, 1,10);
Console.WriteLine("Матрица №2:");
PrintMatrix(B);
Console.WriteLine();
if (n==p) 
{
int [,] C = ProductMatrices(A,B);
Console.WriteLine("Произведение матриц: ");
PrintMatrix(C);
}
else Console.WriteLine("Умножение матриц невозможно");
