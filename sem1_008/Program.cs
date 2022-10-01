/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x =0;
if (num%2 == 0)
{
    x = num;
}
else 
{
    x=num-1;
}
while(x>0)
{
    Console.Write($"{x},"); 
    x = x-2;
}