// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11, 82 -> 10, 9012 -> 12

//определение функции
int SumDigitsOfNumber (int num)
{
    num = Math.Abs(num);
    // ввод переменных для цифры и суммы цифр
    int digit = 0;
    int sum = 0;

    while (num > 0)
    {
        digit = num % 10;
        sum += digit;
        num = num / 10;
    }
    return sum;
}

// запрос данных у пользователя
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// обращение к функции
int result = SumDigitsOfNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");
