// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Request(string message)
{
    Console.Write($"{message}: ");
    int req = Convert.ToInt32(Console.ReadLine());
    return req;
}

int SumOfNumbers(int num)
{   

    int result = 0;
    while (num > 0)
    {
        int num1 = num % 10;
        result = result + num1;
        num =  num / 10;
    }
    
    return result; 
}

int n = Request("Введите число");
int res = SumOfNumbers(n);
Console.WriteLine(res);