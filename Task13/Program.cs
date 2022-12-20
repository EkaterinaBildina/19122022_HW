﻿// Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// Проверка:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next();
int count = number;

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (count > 999)
    {
        count = count / 10;

        if (count > 100 && count < 1000)
            break;
    }
int result = count % 10;
Console.WriteLine($"третья цифра числа {number} -> {result}");
}