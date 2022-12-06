/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message) //Вывод результатов того, что ввел пользователь
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 6 || a == 7)
        {
            Console.Write("Ура! " + a + " - Это - Выходной");
        }
        else
        {
            Console.Write("Жаль... " + a + " - Это - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число, которое входит за интервал от 1 до 7, поэтому, понять какой это день - невозможно...");
    }
    return " день.";
}