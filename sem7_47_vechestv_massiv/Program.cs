

void FillArr (double [,] Array)
{
   for (int i = 0; i < Array.GetLength(0); i++)
   {
     for (int j = 0; j < Array.GetLength(1); j++)
     {
        Array[i,j] = Math.Round((new Random().NextDouble() * 10),2);
     }
   }
}
void PrintAr(double[,]Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
     for (int j=0; j<Array.GetLength(1); j++)
     {
        Console.Write ($"{Array[i,j]}\t");
        
     }  
     System.Console.WriteLine(); 
    }
}
double[,]Massiv = new double[6,3];
FillArr(Massiv);
PrintAr(Massiv);