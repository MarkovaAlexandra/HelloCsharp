// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int num = 10;                                 // тут можно менять
Console.WriteLine($"Введите {num} чисел");
int []Massiv = new int [num];
int count=0;
for( int i=0;i<num;i++)
{
    Console.WriteLine($"Введите число{1+i}");
    Massiv[i]=Convert.ToInt32(Console.ReadLine());
    if (Massiv[i]>0) count++;
}
//Console.WriteLine(string.Join(",",Massiv));
Console.WriteLine($"Вы ввели {count} чисел больше 0");