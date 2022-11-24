// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
numberB = Math.Abs(numberB);

int DegreeB(int numA, int numB) // метод для положительных чисел
{
    int step = 1;
    int degree = numA;
    while (step < numB)
    {
        degree = degree * numA;
        step++;
    }
    return degree;
}
int DegreeNegative(int num1, int num2) // метод для отрицательного числа А
{
    int count = 1;
    int degreeNegative = num1;
    while (count < num2)
    {
        degreeNegative = degreeNegative * num1;
        count++;
    }
    if (degreeNegative > 0)
        degreeNegative = degreeNegative * -1;
    return degreeNegative;
}

if (numberA < 0)
{
    int endresult = DegreeNegative(numberA, numberB);
    Console.WriteLine($"Число А ({numberA}) в степени B ({numberB}) равно {endresult}.");
}
else
{
    if (numberB != 0)
    {
        int endresult = DegreeB(numberA, numberB);
        Console.WriteLine($"Число А ({numberA}) в степени B ({numberB}) равно {endresult}.");
    }
    else
    {
        Console.WriteLine("В качестве B введите натуральное число!");
    }
}