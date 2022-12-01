// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string strNumber = "2";
string outLine = strNumber;
if (number < 2){
    outLine = "Нет решения.";
};
for (int i=4; i<=number; i+=2){
    strNumber = i.ToString();
    outLine = ($"{outLine}, {strNumber}");
}
Console.WriteLine(outLine);