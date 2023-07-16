// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > num1) max = num2;
    if (num3 > num2) max = num3;
Console.Write($"{num1}, {num2}. {num3} -> {max}");