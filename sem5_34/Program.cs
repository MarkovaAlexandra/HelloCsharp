// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int []Array = new int[20];
int i=0;
while(i<Array.Length)
{
    Array[i]=new Random().Next(0,100);
    i++;
}
Console.WriteLine(string.Join(",",Array));
int count=0;
for (i=0;i<Array.Length;i++)
{
    if(Array[i]%2 ==0)count++;
}
Console.WriteLine(count);



