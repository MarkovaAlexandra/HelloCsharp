
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void FillMassiv(int [,] Massiv)
{
    for(int i=0;i<Massiv.GetLength(0);i++)
    {
        for( int j=0; j<Massiv.GetLength(1); j++)
        {
            Massiv[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintMassiv (int[,] Massiv)
{
    for( int i=0;i<Massiv.GetLength(0);i++)
    {
        for(int j=0;j<Massiv.GetLength(1);j++)
        {
            Console.Write($"{Massiv[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите кол-во строк массива");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов массива");
int y = Convert.ToInt32(Console.ReadLine());
int [,]Array = new int [x,y];

FillMassiv(Array);
PrintMassiv(Array);

void SredArifStolbtsa (int [,] Massiv, int chislostrok, int chislostolbtsov)

{
    double [] ArifmVStolbtse = new double[chislostolbtsov]; //здесь поменять на y 
    int pos=0;
    for (int j=0; j<Massiv.GetLength(1);j++)
      {   
        double result=0;
        for (int i=0;i<Massiv.GetLength(0);i++)
        {
            result=result+Massiv[i,j];
            //System.Console.WriteLine(result);
        }
    ArifmVStolbtse[pos]=Math.Round((result/chislostrok),2);
   // System.Console.WriteLine($"{ArifmVStolbtse[pos]}=арифм в столбце {pos}");
    pos++;
}   
System.Console.WriteLine("Среднее арифметическое столбца");
System.Console.WriteLine(string.Join("\t",ArifmVStolbtse));
}

SredArifStolbtsa(Array,x,y);

