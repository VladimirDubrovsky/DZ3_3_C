// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введи число N");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;

// Первый способ

while (i<=N)
{
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}

// Второй способ

// for (int i = 1; i <= N; i++)
// {
//     double result = Math.Pow(i, 3);
//     Console.WriteLine(result);
// }