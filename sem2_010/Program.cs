//Задача10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


int x = Convert.ToInt32(new Random().Next(0,1000));
Console.WriteLine($"случйное число {x}");
int x1=x%100;
int x2=x1/10;
Console.WriteLine(x2);

Console.WriteLine("Теперь решение через строки");
string s = Convert.ToString(new Random().Next(100,1000));
Console.WriteLine(s);
Console.WriteLine(s[1]);
