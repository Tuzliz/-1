﻿Console.WriteLine("Введите число 1 -> ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 -> ");
int num2 = int.Parse(Console.ReadLine());
bool result = num2 * num2 == num1;
Console.WriteLine(result ? "да" : "нет");