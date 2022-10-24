// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FillArr(int [,] Massiv)
{
  for(int i=0;i<Massiv.GetLength(0);i++)
  {
    for (int j=0 ; j<Massiv.GetLength(1);j++)
    {
        Massiv[i,j]=new Random().Next(-10,10);
    }
  }
}

void PrintArray (int [,]Massiv)
{
for (int i = 0; i < Massiv.GetLength(0); i++)
{
    for (int j = 0; j < Massiv.GetLength(1); j++)
    {
        Console.Write($"{Massiv[i,j]}\t");
    }
    System.Console.WriteLine();
}
}

int FindElement (int[,]Nums, int x, int y)
{

int element=0;
if(x>=Nums.GetLength(0)||y>=Nums.GetLength(1))
{
    System.Console.WriteLine("Такой позиции нет");
}
else

{   
    
   for(int i=0;i<Nums.GetLength(0);i++)
   if(i==x)
   {
    for (int j=0;j<Nums.GetLength(1);j++)
    {
        if (j==y)
        element=Nums[i,j];
    }
   }
   }
   return element;
}

System.Console.WriteLine("Задайте кол-во строк массива");
int stroki = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте кол-во столбцов массива?");
int stolbci = Convert.ToInt32(Console.ReadLine());
int [,] Massivnew =new int [stroki,stolbci];
FillArr(Massivnew);
PrintArray(Massivnew);
System.Console.WriteLine("В какой строке будем искать?");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("в каком столбце будем искать?");
int y = Convert.ToInt32(Console.ReadLine());
int elementx = FindElement(Massivnew,x,y);
System.Console.WriteLine($"На заданной позиции находится элемент {elementx}");
