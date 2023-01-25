// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Request(string message)
{
    Console.Write($"{message}: ");
    int req = Convert.ToInt32(Console.ReadLine());
    return req;
}

int Exponentiation(int num, int deg)
{
    int result = 1;
    for (int i = 0; i < deg; i++)
    {
        result *= num;
        
    }
    return result;
}

int a = Request("Введите число 'A'");
int degree = Request("Введите число 'B'");
int expon = Exponentiation(a, degree);
Console.WriteLine(expon);


