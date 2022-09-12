// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень В. 
//Решить задачу с использованием методов. 3, 5 -> 243 (3⁵), 2, 4 -> 16.

// определение функции:
int ExponentiationNumber (int number1, int number2)
{
    int mult = number1;
    number2 = Math.Abs(number2);
    for (int i = 1; i < number2; i++)
    {
    mult = mult * number1;
    }
    return mult;
}

// запрос данных у пользователя:
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());

// обращение к функции:
int result = ExponentiationNumber(numberA, numberB);

// вывод ответа пользователю:
if (numberB > 0) // для положительной степени
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
}
else // для отрицательной степени
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = 1 / {result}");
}
