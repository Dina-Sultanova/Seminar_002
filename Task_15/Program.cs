// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Нет, это будний день"); break;
    case 2: Console.WriteLine("Нет, это будний день"); break;
    case 3: Console.WriteLine("Нет, это будний день"); break;
    case 4: Console.WriteLine("Нет, это будний день"); break;
    case 5: Console.WriteLine("Нет, это будний день"); break;
    case 6: Console.WriteLine("Да, это выходной день"); break;
    case 7: Console.WriteLine("Да, это выходной день"); break;
    default: Console.WriteLine("Такого дня недели не существует"); break;
}
Console.ReadKey();