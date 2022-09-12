// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
PrintArray(arr);
// for (int i =0; i < rows; i++){
//     for (int j =0; j < columns; j++){
//         System.Console.Write($"{arr[i, j]} ");
//     }
//     System.Console.Write("\n");
// }
System.Console.WriteLine();
int[, ] Task49(int[, ] matrix) {
for (int i = 1; i < matrix.GetLength(0); i+=2) {
for (int j = 1; j < matrix.GetLength(1); j+=2) {
matrix[i, j] *= matrix[i, j];
}
}
return matrix;
}

PrintArray(Task49(arr));

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    
}