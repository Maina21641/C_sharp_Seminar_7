// Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
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
for (int i =0; i < rows; i++){
    for (int j =0; j < columns; j++){
        System.Console.WriteLine($"{arr[i, j]} ");
    }
    System.Console.WriteLine();
}
    
