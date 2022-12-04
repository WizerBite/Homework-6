/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

int new_value()
{
    return int.Parse(Console.ReadLine());
}

void f_arr(int[] arr, int min, int max) // запись массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
}

void write_arr(int[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void f_2_arr(int[,] arr, int min, int max) // запись двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}   

void write_2_arr(int[,] arr) // вывод двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }               
        Console.WriteLine();
    }
    Console.WriteLine();
}

void task1()
{
    Console.WriteLine("Введите сколько чисел вы хотите ввести: ");
    int count = 0;
    int finish = new_value();
    for (int i = 0; i < finish; i++)
    {
        Console.WriteLine($"Число {i+1}: ");
        if (new_value() > 0)
            count++;
    }
    Console.WriteLine($"Чисел больше нуля: {count}");
}

void task2()
{
    int b1, k1, b2, k2;
    Console.WriteLine($"Введите 4 переменные (b1, k1, b2 и k2) подряд:")
    Console.WriteLine(  $"b1: {b1 = new_value()} " +
                        $"\nk1: {k1 = new_value()} " +
                        $"\nb2: {b2 = new_value()} " +
                        $"\nk2: {k2 = new_value()} "    );
    double y1x0 = k1 * 0 + b1, y1x1 = k1 * 1 + b1,
        y2x0 = k2 * 0 + b2, y2x1 = k2 * 1 + b2,
        y1 = y1x0, y2 = y2x0, x = 0;

    if ((y1x0 - y1x1) != (y2x0 - y2x1))
    {
        while (y1 != y2)
        {

            if (((y1x0 - y1x1) > (y2x0 - y2x1) &&
                y1x0 > y2x0) ||
                ((y1x0 - y1x1) < (y2x0 - y2x1) &&
                y1x0 < y2x0))
                x += 0.001;
            else
                x -= 0.001;
            y1 = k1 * Math.Round(x,3) + b1;
            y2 = k2 * Math.Round(x,3) + b2;
        }
        Console.WriteLine($"точка пересечения: ({Math.Round(x,3)};{y1})");
    }
    else
        Console.WriteLine("У этих прямых нет точки пересечения");
}




while (true)
{ 
    Console.Write("Введите номер задачи: ");
    int num = int.Parse(Console.ReadLine());
    switch(num)
    {
        case 1:
            {
                task1();
                break;
            }
        case 2:
            {
                task2();
                break;
            }
        
    }    
}
