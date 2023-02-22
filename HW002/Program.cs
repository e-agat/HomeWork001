//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите три числа: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max && b > c)
{
    max = b;
}
else if (c > max && c > b)
{
    max = c;
}
else
{
    max = a;
}
Console.WriteLine("Максимальное число = " + max);