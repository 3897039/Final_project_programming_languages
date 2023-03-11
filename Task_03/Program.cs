// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int AckermanFunction(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AckermanFunction(m - 1, 1);
			}
			return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
		}

int numberM = InputInt("Введите число m -> ");
int numberN = InputInt("Введите число n -> ");
Console.WriteLine($" Функция Аккермана A(m,n) = {AckermanFunction(numberM, numberN)}");
