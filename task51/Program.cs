// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m, int n){
    int [,] result = new int [m, n];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(100);
        }
    }
    return result;
}
int[,] arr = GetArray(rows, columns);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
Console.WriteLine();
}

//System.Console.WriteLine();
int Sum(int[, ] arr) 
{
int sum = 0;
for (int i = 0; i < arr.GetLength(0); i++) 
{
sum += arr[i, i];
}
return sum;
}
System.Console.WriteLine(Sum(arr));
