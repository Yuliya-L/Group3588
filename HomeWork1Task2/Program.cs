﻿// данные консоли
int max = 0;
int min = 0;

//Преобразование значений
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// сравниваем зачения

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}

//вывод данных
Console.WriteLine("max = " + max + " и " + "min = " + min);