// Задача 6: Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число для проверки на четность: ");
int firstNumber = int.Parse(Console.ReadLine());
string answer = "Нет";
int result = firstNumber % 2;
if (result == 0){
    answer = "Да";
};
Console.WriteLine(answer);