// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе. Через строку решать нельзя.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Summa (int N)
{
    int x = 0;
    int n = N;
    int sum = 0;
    for (int i = 1; i < N; i = i * 10)
        {
            sum = sum + (n % 10);
            n = n / 10;
            x++;     
        } 
        return sum;       
}

Summa (N);
Console.WriteLine($"Сумма цифр {N} = {Summa (N)}");
