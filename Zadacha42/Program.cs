/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. */

var m = int.Parse(Console.ReadLine()!);
Console.WriteLine(string.Format("Число в 10-й системе = {0}", m));
string tmp = "";
while (m > 0)
{
    tmp = (m & 1) + tmp;// Аналог %2 или взятие последнего бита.
    m = m >> 1; // Аналог целочисленного деления на 2.
}
Console.Write(string.Format("Число в двочиной системе = {0}", tmp));
