//Напишите программу, которая принимает на вход целое положительное число N и 
//координаты двух точек и находит расстояние между ними в N-мерном пространстве.

Console.Write("Please, enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

int dimensions = N;

int[] first_point = new int[N];
int[] second_point = new int[N];

void FillArray(string name, int[] arr)
{
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Please, enter coordinate {i+1} of the {name}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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


FillArray("Point 1", first_point);

Console.WriteLine("Coordinates of the Point 1 are:");
PrintArray(first_point);
Console.WriteLine();

FillArray("Point 2", second_point);
Console.WriteLine("Coordinates of the Point 2 are:");
PrintArray(second_point);
Console.WriteLine();

double FindDistance(int[] pointa, int[] pointb)
{
    double residuals = 0;
    double distance = 0;

    for (int i = 0; i < pointa.Length; i++)
    {
        residuals = Math.Pow((pointa[i] - pointb[i]), 2);
        distance += residuals;
    }
    return distance;
}

Console.WriteLine(FindDistance(first_point, second_point));