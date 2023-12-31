﻿//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine()!);


void Dot(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают и не имеют точек пересечения");
        }
        else
        {
            Console.WriteLine("Прямые параллельны другу друг и не имеют точек пересечения");
        }
    }
    else
    {
        double X = (b2 - b1) / (k1 - k2);
        double Y = k1 * X + b1;
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}

Dot(b1, k1, b2, k2);





