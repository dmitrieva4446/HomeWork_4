// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int f(int n)
{
    int count = 0;
    int sum = n % 10;
    while (n > 0)
    {
        n /= 10; 
        sum += n % 10;
        count ++;
    }
    return sum;
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));