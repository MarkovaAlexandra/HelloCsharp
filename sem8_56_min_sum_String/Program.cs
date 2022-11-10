// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
void FillArray(int [,] Massiv)
{
    for (int i=0;i<Massiv.GetLength(0);i++)
    {
        for (int j = 0; j <Massiv.GetLength(1); j++)
        {
            Massiv[i,j]=new Random().Next(0,10);
        }
    }
}
void PrintAray(int[,]Massiv)
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
int [,] Zadacha56 = new int[2,4];
FillArray(Zadacha56);
PrintAray(Zadacha56);
int MinSum(int [,] Massiv)
{
    int []Sums = new int[Massiv.GetLength(0)];
    
    for (int i = 0; i < Massiv.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < Massiv.GetLength(1); j++)
        {
            sum=sum+Massiv[i,j];
        }
        Sums[i]=sum;
        System.Console.WriteLine($"сумма элементов в строке {i}={sum}");
    }
    int min = Sums[0];
    int index=0;
    for (int i = 0; i < Sums.Length; i++)
    {
        if (Sums[i]<min)
        {
            min=Sums[i];
            index=i;
        }
    }
    return index;
}
int minSumString=MinSum(Zadacha56);
System.Console.WriteLine($"минимальная сумма элементов в строке {minSumString}");