﻿//  Задача 8: Напишите программу, которая на вход принимает число (N), 
//  а на выходе показывает все чётные числа от 1 до N.

//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

// В задаче не указано, какие должны быть числа, мы должны это уточнить, 
// но так как в примерах указаны только целые числа, работаем с ними, но в обращении к
// пользователю укажем "Введите целое число"

Console.WriteLine("Введите целое число больше 1");

int number = 0;

while(true) { 
    Console.WriteLine("Введите целое число больше 1"); 
    number = int.Parse(Console.ReadLine());
    if(number > 1) break;
    else Console.WriteLine("Вы ввели неверное число.");
}

Console.WriteLine("Вы ввели верное число, программа выведет на экран интервал целых чисел от 1 до введённого числа:");

int count = 2;
Console.Write(count);
count += 2;
while(count <= number) {
    Console.Write(", " + count);
    count += 2;
}
