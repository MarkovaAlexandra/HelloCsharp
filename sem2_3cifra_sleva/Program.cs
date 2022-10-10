// Вывести третью цифру слева
int num = new Random().Next(0,int.MaxValue);
Console.WriteLine($"random = {num}");
if (num<100) Console.WriteLine("третьей цифры нет");
long i =1000;
int result = 0;
int delitel = 1;
while (num<int.MaxValue)
{
    if(num<i)
    {
        result=num/delitel%10;
        Console.WriteLine(result);
        break;
    }
    i=i*10;
    delitel=delitel*10;
}
