// Задача 2: Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 => 7
// 44, 5, 78 => 78
// 22, 3, 9 => 22


Console.Write("Введите первое число из трех ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число из трех ");
int secondValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число из трех ");
int trirdValue = Convert.ToInt32(Console.ReadLine());


if(firstValue < secondValue)
{
    int maxValue = secondValue;
    if(trirdValue > maxValue)
    {
        Console.WriteLine("max = " + trirdValue);
    }
    else
    {
        Console.WriteLine("max = " + maxValue);
    }
}
else
{
    int maxValue = firstValue;
    if(trirdValue > maxValue)
    {
        Console.WriteLine("max = " + trirdValue);
    }
    else
    {
        Console.WriteLine("max = " + maxValue);
    }
}