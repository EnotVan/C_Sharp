// Задача 1: Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.
// a=5;b=7 => max=7, min=5
// a=2;b=10 => max=10, min=2
// a=-9;b=-3 => max=-3, min=-9


Console.Write("Введите первое значение: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе значение: ");
int secondValue = Convert.ToInt32(Console.ReadLine());


if(firstValue > secondValue)
{
    Console.WriteLine("max = " + firstValue + ", min = " + secondValue);
}
else
{
    Console.WriteLine("max = " + secondValue + ", min = " + firstValue);
}

