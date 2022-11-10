// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Fillarray(int [,] Massiv)
{
    for (int i = 0; i < Massiv.GetLength(0); i++)
    {
        for (int j = 0; j < Massiv.GetLength(1); j++)
        {
            Massiv[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int [,]Massiv)
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
int [,] Array = new int[4,4];
Fillarray(Array);
PrintArray(Array);
void SortArray (int [,] Massiv)
{
    for ( int i = 0; i < Massiv.GetLength(0); i++)
     {
         for ( int count = 0; count < Massiv.GetLength(0); count++)
         {    
              for (  int temp=0,j=0; j < Massiv.GetLength(1)-1; j++)
              {
                   if (Massiv[i,j]>Massiv[i,j+1])
                    {
                      temp=Massiv[i,j];
                     Massiv[i,j]=Massiv[i,j+1];
                     Massiv[i,j+1]=temp;
                     }

              }
         }
     }
}
System.Console.WriteLine();
SortArray(Array);
PrintArray(Array);

