// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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
int strings=10;
int rows=10;
int [,] Spiral = new int [strings,rows];
int count=0;
if (strings<rows) count =strings/2;
else count =rows/2;
PrintArray(Spiral);
int x=1;
int lastStroka=strings-1;
int lastStolbes = rows-1;
int first=0;
Spiral[0,0]=x;
int i=0;
int j=0;
for (;count>=1;count--,first++,lastStroka--,lastStolbes--)
{
    
    for ( i=first, j=first;j<=lastStolbes;j++,x++)
    {
        Spiral[i,j]=x;
    }

for ( i = first+1,j=lastStolbes; i <=lastStroka; i++,x++)
{
     Spiral[i,j]=x;
}

for ( i = lastStroka,j=lastStolbes-1; j >=first ; j--,x++)
{
      Spiral[i,j]=x;
}

for (i=lastStroka-1,j=first; i>=first+1;i--,x++)
{
          Spiral[i,j]=x;
  
}

}
PrintArray(Spiral);
System.Console.WriteLine();
