// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[]Array=new double[10];
int index=0;
for(index=0;index<Array.Length;index++)
{
    Array[index]=Convert.ToDouble( new Random().Next(-1000,1000));
}
Console.WriteLine(string.Join(",",Array));
double max=0;
for(index=0;index<Array.Length;index++)
{
    if (Array[index]>max)max=Array[index];
}
Console.WriteLine($"max= {max}");
double min=0;
for (index=0;index<Array.Length;index++)
{
    if (Array[index]<min)min=Array[index];
}
Console.WriteLine($"min = {min}");
double result = max-min;
Console.WriteLine($"Разница между макс и мин значениями массива = {result}");