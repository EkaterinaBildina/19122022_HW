// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// Проверка
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0 || number > 7)
{
    Console.WriteLine("Ошибка ввода числа: в неделе 7 дней");
}
else
    Console.WriteLine(DayNumber(number) ? "Да" : "Нет");

bool DayNumber(int daynum)
{
    return daynum == 6 || daynum == 7;
}


