﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Ошибка !!! Число не пятизначное");
    return;
}
 int digit1 = number / 10000;
 int digit2 = number / 1000 % 10;
 int digit3 = number / 100 % 10;
 int digit4 = number / 10 % 10;
 int digit5 = number % 10;

 if (digit1 == digit5 && digit2 == digit4)
 {
    Console.WriteLine($" Число {number} является палиндромом");
 }
else
{
    Console.WriteLine($" Число {number} не является палиндромом");
}

