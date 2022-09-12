// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EntryData(string message)                                  //метод ввода целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = EntryData("Введите целое число -> ");            // вводим число
int result = 0;
while(number > 0)                                             // вычисляем сумму цифр
{
    result = result + number % 10;
    number = number/10;
}

System.Console.WriteLine($"Сумма цифр равна {result}");      // выводим результат

