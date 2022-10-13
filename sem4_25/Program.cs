
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Stepen(int x, int y)
{
    int result=x;
    for(result=x; y>1; y--)
    {
        result=result*x;
    }
    return result;
}
     
//     int result=x;
//     while(y>1)
//     {
//         result = result*x;
//         Console.WriteLine(result);
//         y--;
//         Console.WriteLine(y);
//     }
//     return result;
// }
 int d = Stepen(3,5);
 Console.WriteLine(d);
 int f= Stepen(8,3);
 Console.WriteLine(f);
 