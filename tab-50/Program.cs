//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.Write("Введите позицию элемента в формате \"строка,столбец\": ");
        string positionInput = Console.ReadLine();

        string[] position = positionInput.Split(',');
        int row = int.Parse(position[0]);
        int column = int.Parse(position[1]);

        if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
            int element = array[row, column];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }

        Console.ReadLine();
    }
}
