﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)                                 //метод заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,1000);
    }
}
void PrintArray(int[] array)                                //метод вывода массива на экран
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);
