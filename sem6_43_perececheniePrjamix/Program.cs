// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
decimal x=0;
decimal y=0;
Console.WriteLine("Найдем точку пересечения двух прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите k1");
decimal k1=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите b1");
decimal b1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите k2");
decimal k2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите b2");
decimal b2 = Convert.ToDecimal(Console.ReadLine());
x=Math.Round((b2-b1)/(k1-k2),2);
//Console.WriteLine(x);
y=k1*x+b1;
//Console.WriteLine(y);
Console.WriteLine($"Точка пересечения ({x}; {y})");