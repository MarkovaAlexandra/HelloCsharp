
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumCifr(int x)
{
    if (x<0) x=x*-1;
    int count=1;
    int edinicVRazriade = 0;
    int sum=0;
    // while(x>0)
    // { 
    //     edinicVRazriade=x%10;
    //     x=x/10;
    //     count++;
    //     //Console.WriteLine($"{edinicVRazriade}");
    //     sum=sum+edinicVRazriade;
    // }
    for(sum=0; x>0; count++)
    {
        edinicVRazriade=x%10; 
        x=x/10;sum=sum+edinicVRazriade;
    }
    return sum;
}

int t = new Random().Next();
Console.WriteLine(t);
int m=SumCifr(t);
Console.WriteLine(m);