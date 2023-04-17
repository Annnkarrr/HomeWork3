/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите точку А, координату по оси х: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку А, координату по оси y: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку А, координату по оси z: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку B, координату по оси х: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку B, координату по оси y: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку B, координату по оси z: ");
double z2 = double.Parse(Console.ReadLine());

double dlina = Math.Sqrt(Math.Pow((x2 - x1), 2)+ Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine(dlina);