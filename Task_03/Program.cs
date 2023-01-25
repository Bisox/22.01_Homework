// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  Реализовать через функции. 

int RandomRange(string message)
{
   Console.Write($"{message} ");
   int number = Convert.ToInt32(Console.ReadLine());
   return number;
}

int[] ArrayOfEight(int rangeA, int rangeB, int sizeArray)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(rangeA, rangeB);
    }
    return array;
}   

void PrintArray(int[] ArrayOf)
{
    for (int j = 0; j < ArrayOf.Length; j++)
    {
        Console.Write($"{ArrayOf[j]}, ");
        
    }
}

int a = RandomRange("Введите начало диапазона: ");
int b = RandomRange("Введите конец диапазона: ");
int size = RandomRange("Введите размер массива: ");
PrintArray(ArrayOfEight(a, b, size));

