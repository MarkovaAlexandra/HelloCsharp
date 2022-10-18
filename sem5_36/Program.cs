// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] Array = new int[10];
int i=0;
for (i=0;i<Array.Length;i++)
{
    Array[i]=new Random().Next(-10,10);
}
Console.WriteLine(string.Join(",",Array));
int sum=0;
for (i=1;i<Array.Length;i=i+2)
{
    sum=sum+Array[i];
}
Console.WriteLine(sum);