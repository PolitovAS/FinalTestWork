/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
Console.WriteLine("Введите элементы массива через пробел: ");
string[] array = (Console.ReadLine() ?? "").Split();
string[] arrResult = new string[array.Length];

int len = 3;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= len)
    {
        arrResult[count] = array[i];
        count++;
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

PrintArray(arrResult);