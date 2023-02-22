//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 2;
Console.WriteLine("Все четные числа от 1 до " + n + ":");
while (a <= n)
{

    Console.WriteLine(a);
    a = a + 2;
}
