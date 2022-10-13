
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void CreateArray (int [] numbers,int lenght)
{
  // int index=0;
  // while(index<lenght)
  // {
  //   numbers[index]=new Random().Next(0,1000);
  //   Console.Write($"{numbers[index]},");
  //   index++;
  Console.Write("(");
for (int index=0;  index<lenght; index++)
{
    numbers[index]=new Random().Next(0,1000);
    Console.Write($"{numbers[index]},");
}
Console.Write(")");
}

int [] Massiv=new int [8];
CreateArray(Massiv,8);