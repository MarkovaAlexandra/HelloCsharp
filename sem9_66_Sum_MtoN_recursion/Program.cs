// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNums (int m, int n)
{
    if(n==m+1) return(m+n);
    else return (n+SumNums(m,n-1));
}
System.Console.WriteLine("Введите число M");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    int temp=0;
    temp=a;
    a=b;
    b=temp;
}
int sum = SumNums(a,b);
System.Console.WriteLine(sum);
