﻿// Задача 9: Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2)

{
Console.Write(digit1);
Console.WriteLine(" - большая цифра");
}
else if (digit2 > digit1)
{
Console.Write(digit2);
Console.WriteLine(" - большая цифра");
}
else
{
 Console.Write("Цифры равны");   
}
