﻿//Напишите программу, которая выводит массив из 8 элементов,
 //заполненный случайными числами. Оформите заполнение массива и вывод в виде функции 
 //(пригодится в следующих задачах). Реализовать через функции.
  //(* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int n = 8; 
int[] arr = new int[n];

Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(1,10);
}
Console.WriteLine(string.Join(", ", arr));