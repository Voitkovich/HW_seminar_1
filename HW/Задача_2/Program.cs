// Программа, которая пинимает на вход два числа и выдает какое число больше, а какое меньше.

Console.Write("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Число A больше числа B");
}
else
{
    if (numberA < numberB)
    Console.WriteLine("Число B больше числа A");
}