// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Request(string message)
{
    Console.Write($"{message}: ");
    int req = Convert.ToInt32(Console.ReadLine());
    return req;
}

int Exponentiation(double num, double deg)
{
    double result = 0;
    for (int i = 1; num > i; i += 1)
    {
        result = Math.Pow(num, deg);;
    }
    return Convert.ToInt32(result);
}

int a = Request("Введите число 'A'");
int degree = Request("Введите число 'B'");
int expon = Exponentiation(a, degree);
Console.WriteLine(expon);


