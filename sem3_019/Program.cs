// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
int x=Convert.ToInt32(Console.ReadLine());
int x1=x%10;
int x10=x%100/10;
int x100=x%1000/100;
int x1000=x%10000/1000;
int x10000=x/10000;
//Console.Write($"{x1},{x10},{x100},{x1000},{x10000}");
if(x1==x10000 && x10==x1000)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом"); 
}




