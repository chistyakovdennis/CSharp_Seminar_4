﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

  
        int[] arr = new int[8]; // создаем массив из 8 элементов
        Random rnd = new Random(); // создаем объект для генерации случайных чисел

        // заполняем массив случайными числами от 0 до 100
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rnd.Next(0, 101);
        }

        // выводим массив на экран
        Console.Write("Массив: ");
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
  