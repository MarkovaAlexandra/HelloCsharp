// // Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 3267912 -> 6


// string q = Convert.ToString(new Random().Next());
// Console.WriteLine(q);
// //Console.WriteLine(q.Length);
// if (q.Length>3)
// {
// Console.WriteLine(q[2]);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

int num = new Random().Next(0,int.MaxValue);
Console.WriteLine($"случайное число {num}");

if (num<100)
{ 
    Console.WriteLine("третьей цифры нет");
}
int result = 0;// третья цифра
long s=1000;//будем сравнивать рандомное число с этим
int a=10;//будем искать остаток от деления на а
int b=1;//будем делить остаток на b
int result1=0;// первый промежуточный рез
while(num<int.MaxValue)
{
if (num<s)
{
        result1=num%a;
    if (result1>b)
    {
        result=result1/b;
    }
    if (result1<b)//когда третья цифра 0
    {
        result = 0;
    }
    Console.WriteLine(result);
    break;
}
a=a*10;
b=b*10;
s=s*10;
}


