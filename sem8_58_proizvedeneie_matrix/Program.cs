// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//элемент результирующей матрицы [i,j] = сумма произведенией i столбца* j строку
// 2*3+4*3=18
// 2*4+4*3=20
// 3*3+2*3=15
// 3*4+2*3=18
void Fillarray(int[,]Massiv)
{
    for (int i = 0; i < Massiv.GetLength(0); i++)
    {
        for (int j = 0; j < Massiv.GetLength(1); j++)
        {
            Massiv[i,j]= new Random().Next(0,10);
        }
    }
}
void PrintArray(int[,] Massiv)
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

Console.WriteLine("Введите кол-во строк первой матрицы");
int strok1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов первой матрицы");
int stolbzov1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк второй матрицы.!!Должно совпадать с кол-вои столбцов первой матрицы!!");
int strok2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов второй матрицы");
int stolbzov2=Convert.ToInt32(Console.ReadLine());
if(stolbzov1!=strok2)Console.WriteLine("кол-во столбцов первой матрицы не равно кол-ву строк второй. Умножение матриц невозможно");
else
{
int [,] Matrix1=new int [strok1,stolbzov1];
int [,] Matrix2=new int [strok2,stolbzov2];
Fillarray(Matrix1);
Fillarray(Matrix2);
System.Console.WriteLine("Первая матрица");
PrintArray(Matrix1);
System.Console.WriteLine("Вторая матрица");
PrintArray(Matrix2);
int [,] MatrixResult=new int [strok1,stolbzov2];
int ii=0;
int jj=0;
MatrixResult[ii,jj]=0;
for ( ii = 0; ii< MatrixResult.GetLength(0); ii++)
{
    for (jj= 0; jj < MatrixResult.GetLength(1); jj++)
    {  
        for (int i = 0,j=0; i<strok2&&j<stolbzov1; i++,j++)
        {  
        MatrixResult[ii,jj]=MatrixResult[ii,jj]+Matrix1[ii,j]*Matrix2[i,jj];
        }
    }
}
System.Console.WriteLine("Результирующая матрица");
PrintArray(MatrixResult);
}
