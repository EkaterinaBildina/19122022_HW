// Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// Проверка:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = Convert.ToInt32(new Random().Next());

if (number < 100) Console.WriteLine("третьей цифры нет");

int count = number;

while (count > 999)
{
    count = number / 10;
}
break;

int result = count % 10;
Console.WriteLine($"третья цифра числа {number} -> {result}");