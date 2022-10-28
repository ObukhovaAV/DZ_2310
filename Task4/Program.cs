// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
int Factorial (int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)       
        result*=i; 
       
    return result;
}


Console.WriteLine("Введите количество строк треугольника Паскаля");
int N = int.Parse(Console.ReadLine()?? "0");
//int n = 0;
for (int n = 0; n < N; n++)
{
    for (int i = 0; i <= N - n; i++)

    {
        Console.Write(" ");
    }
    for (int j = 0; j <= n; j++)
    {
        Console.Write(" ");
        Console.Write(Factorial(n) / (Factorial(j) * Factorial(n - j)));
       
    }
Console.WriteLine();

}