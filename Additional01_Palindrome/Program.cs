//Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.


Console.Write("Please, enter number: ");

string num = Console.ReadLine();

bool Palindrome(string number)
{
    bool palindrome = true;
    for (int i = 0; i < number.Length / 2 + number.Length % 2; i++)
    {
        if (number[i] != number[number.Length - i -1])
        {
            palindrome = false;
        }
    }
    return palindrome;
}

Console.WriteLine(Palindrome(num));

