// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write ("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
int maxNumber = firstNumber;
if (secondNumber > maxNumber){
    maxNumber=secondNumber;
};
Console.Write($"max = {maxNumber}");