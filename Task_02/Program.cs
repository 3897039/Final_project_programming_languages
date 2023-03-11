// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int InputInt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int ShowNumber(int first, int second)
{
    if (first > second) return 0;
    return first + ShowNumber(first + 1, second);
}

int num = InputInt("Введите число M -> ");
int second = InputInt("Введите число N -> ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {ShowNumber(num, second)}");
