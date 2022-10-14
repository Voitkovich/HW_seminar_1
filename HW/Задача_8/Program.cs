// Программа, которая на вход принимает число N, а на выход показывает все четные числа от 1 до N.
Console.Write("Введите число N: ");
 int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
if ( i % 2 ==0)
Console.WriteLine(i);