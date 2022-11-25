// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число:");
int anyNumber = Convert.ToInt32(Console.ReadLine());
anyNumber = Math.Abs(anyNumber);

int SummDigits(int num)
{
    int summDigits = 0;
    while (num != 0)
    {
        summDigits = summDigits + num % 10;
        num = num / 10;
    }
    return summDigits;
}

if (anyNumber == 0)
{
    Console.WriteLine("Веедите число отличное от 0");
}
else
{
    Console.WriteLine($"Сумма чисел введенного числа равна {SummDigits(anyNumber)}");
}