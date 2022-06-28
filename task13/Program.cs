/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Random rand = new Random();
Console.WriteLine("Введите число ");
string number = Console.ReadLine();
void Task13(string number )
{
    if (number.Length < 3)
    {
    Console.WriteLine("Третьей цифры нет");
    }
    else
Console.WriteLine(number [2]);
}
Task13(number);
