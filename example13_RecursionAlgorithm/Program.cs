﻿// двумерные массивы

// // таблица строк
// string[,] table = new string[2, 5]; // создаём новый массив в котором 2 строки и 5 столбцов
// table[1, 2] = "слово";              // положили в массив заданное значение (слово)
//                                     // для печати или вывода массива используем цикл в цикле
// for(int rows = 0; rows < 2; rows++) // вывод строк
// {
//     for(int columns = 0; columns < 5; columns++) // вывод столбцов
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); // вывод в кансоль
//     }
// }

// // матрица (прямоугольная таблица чисел)
// int[,] matrix = new int[3, 4];

// for(int i = 0; i < 3; i++)                  // красивый вывод матрици чисел
// {
//     for(int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");  // вывод в одну строку через пробел
//     }
//     Console.WriteLine();                    // вывод следующей строки через пустую строку
// }

// // универсальное применение цикла
// int[,] matrix = new int[3, 4];

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Заполнение матрицы случайными числами

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            // конкретно обращаемся к элементу на позиции [i, j]
            // используя генератор случайных чисел от 1 до 9 (правая граница не входит)
        }
    }   
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);