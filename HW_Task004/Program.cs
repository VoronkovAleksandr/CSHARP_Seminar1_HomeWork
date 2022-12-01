// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());
int maxNumber = firstNumber;
if (secondNumber > maxNumber){
    maxNumber = secondNumber;
};
if (thirdNumber > maxNumber){
    maxNumber = thirdNumber;
};
Console.WriteLine ($"max = {maxNumber}");