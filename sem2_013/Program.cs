
// // Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 3267912 -> 6


string q = Convert.ToString(new Random().Next());
Console.WriteLine(q);
//Console.WriteLine(q.Length);
if (q.Length>3)
{
Console.WriteLine(q[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

