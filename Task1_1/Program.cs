// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int EntryData(string message)                                                           //метод ввода целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = EntryData("Введите число - основание -> ");                                //вводим число
int power = EntryData("Введите степень в которую нужно возвести основание -> ");        //вводим степень в которую надо возвести
int result = number;

for (int i = 1; i<power; i++)                                                           //запускаем цикл возведения в степень 
{
    if (power == 1)
    {
        System.Console.WriteLine($"{number} в степени {power} = {number}");
    }
    result = result * number; 
}

System.Console.WriteLine($"{number} в степени {power} = {result}");                     //выводим результат

