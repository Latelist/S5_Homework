//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.Write("Please, enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] array = new double[N];

void FillArray(double[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.NextDouble() * 100;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);

double FindResidual(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    double residual = max - min;
    return residual;
}

Console.WriteLine(FindResidual(array));