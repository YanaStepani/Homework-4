﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Элементы массива вводятся пользователем. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19], 6, 1, 33 -> [6, 1, 33]

/*Михаил, я помню, что не  желательно взаимодействовать с пользователем внутри функции,
но пока по другому не смогла решить эту задачу. Мне пока не совсем понятны тонкости преобразования
из строк в числа :) */

// определение функции наполнения массива пользователем:
int[] GetArray()
{
    int[] array = new int[8];

    int count = 1; // счетчик для удобства пользователя (видеть номер вводимого числа)

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число {count}: ");
        int number = int.Parse(Console.ReadLine());
        array[i] = number;
        count++;
    }

    return array;
}

// определение функции печати массива:
void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// вызов функций
int[] array = GetArray();
PrintArrayToConsole(array);
