// 1.
int[] GetArrayFromString (string stringArray){
    string[] nums = stringArray.Split(' '); // массив строк
    int[] result = new int[nums.Length]; // массив интов
    for (int i  = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]); // для каждого интового итема присваиваем итем элемента строчного массива и конвертируем в инт
    }
    return result;
}

int CountPositiveNumbers(int[] arr){
    int count = 0;
    foreach (var item in arr)
    {
        if (item > 0){
            count++;
        }
    }
    return count;
}
System.Console.WriteLine("Введите числа через пробел: ");
int [] numbers = GetArrayFromString(System.Console.ReadLine());
System.Console.WriteLine($"Количество положительных чисел в массиве: {CountPositiveNumbers(numbers)}");

// 2.
string[] stringArray = Console.ReadLine().Split(' ');
double b1 = double.Parse(stringArray[0]);
double b2 = double.Parse(stringArray[1]);
double k1 = double.Parse(stringArray[2]);
double k2 = double.Parse(stringArray[3]);
double[] GetPoint(double b1, double b2, double k1, double k2){
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = (k1 * result[0]) + b1;
    return result;
}
System.Console.WriteLine(string.Join(" ", GetPoint(b1, b2, k1, k2)));