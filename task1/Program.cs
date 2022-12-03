// Напишите программу которая принимает на вход координаты точки (X и Y), 
// причем X != 0 и Y != 0 и выдает номер четверти плоскости в которой находится эта точка

Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Номер четверти 1");
if (x < 0 && y > 0) Console.WriteLine("Номер четверти 2");
if (x < 0 && y < 0) Console.WriteLine("Номер четверти 3");
if (x > 0 && y < 0) Console.WriteLine("Номер четверти 4");