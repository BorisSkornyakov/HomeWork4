// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double EntryData(string message)                                //метод ввода ввещественного числа
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
bool EntryBool(string message)                                  //метод ввода логического значения
{
    System.Console.Write(message);
    return Convert.ToBoolean(Console.ReadLine());
}

bool start = true;
while (start)                                                   //цикл ввода значений основания и степени и возведения основания в указанную степень
{
    double number = EntryData("Введите число - основание -> ");
    double power = EntryData("Введите степень в которую нужно возвести основание -> ");
    double result = Math.Pow(number, power);
    System.Console.WriteLine($"{number} в степени {power} = {result}");
    start = EntryBool("Введите True что бы продолжить вычисления или False что бы прекратить ");    //Проверка окончания цикла
}