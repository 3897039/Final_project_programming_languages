// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void ShowNumber(int first, int second)
{

    if (first > second) return;
    
    if(first % 2 == 0) Console.Write($"{first}  "); 
    ShowNumber(first + 1, second); 
}

int num = InputInt("Введите число M -> ");
int second = InputInt("Введите число N -> ");
Console.WriteLine($" Все чётные числа в промежутке: ");
ShowNumber(num, second);

