/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 if (number == 1)
Console.Write ("Нет. Понедельни рабочий день.");
    else if (number == 2)
Console.Write ("Нет. Вторник рабочий день.");
   else if (number == 3)
Console.Write ("Нет. Среда рабочий день.");
   else if (number == 4)
Console.Write ("Нет. Четвег рабочий день.");
   else if (number == 5)
Console.Write ("Нет. Пятница рабочий день.");
   else if (number == 6)
Console.Write ("Да. Суббота выходной день.");
   else if (number == 7)
Console.Write ("Да. Воскресение выходной день.");

    else 
{
Console.Write ("Введите число соответствующее дню недели (от 1 до 7).");
}
