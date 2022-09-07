//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Write("Please, enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int NumberOfEvens(int[] arr)
{
    int quantity = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0)
        {
            quantity+=1;
        }
    }
    return quantity;
}

FillArray(array);
PrintArray(array);
Console.WriteLine(NumberOfEvens(array));