// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//  выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void FillArray(int[] arr) 
{
    Random fillRndNum = new Random();
    for(int step = 0; step < arr.Length; step++)
    {
        arr[step] = fillRndNum.Next(0,100); 
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int step = 0; step < arr.Length; step++)
    {
        if (step == arr.Length-1)
        {
            Console.Write($"{arr[step]}");
        }
        else
        {
            Console.Write($"{arr[step]}, ");
        }
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);