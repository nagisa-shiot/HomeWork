﻿Console.WriteLine("Введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Число " + number1 + " большее");
    Console.Write("Число " + number2 + " меньшее");
}
else if (number1 == number2)
{
    Console.WriteLine("Число " + number1 + " равно числу " + number2);
}
else
{
    Console.WriteLine("Число " + number2 + " большее");
    Console.Write("Число " + number1 + " меньшее");
}