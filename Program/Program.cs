// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void FillArray(string[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите строку массива под индексом {i}: ");
        array[i] = (Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NewFillArray(string[] array1, string[] array2, int min)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= min)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

Console.Write("Введие количество строк массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];

FillArray(array1, size);
Console.WriteLine();

Console.WriteLine("Первоначальный массив: ");
PrintArray(array1);

int num = 0;
int min = 3;

foreach (string el in array1)
{
    if (el.Length <= min)
        num = num + 1;
}

string[] array2 = new string[num];
Console.WriteLine();

NewFillArray(array1, array2, min);

Console.WriteLine("Результирующий массив: ");
PrintArray(array2);