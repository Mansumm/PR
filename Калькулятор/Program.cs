using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Калькулятор 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, actions;
            do
            {
                Console.WriteLine("Доступны следующие арифметические операции: \n 1. Сложение \n 2. Вычитание \n 3. Умножение \n 4. Деление \n 5. Возведение числа в степень \n 6. Нахождение квадратного корня \n 7. Нахождение одного процента от числа \n 8. Нахождение факториала \n 9. Выход ");
                Console.Write("Введите арифметическую операцию: ");
                actions = int.Parse(Console.ReadLine());

                switch (actions)
                {
                    case 1:
                        Console.Write("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат сложения чисел: " + (a + b));
                        break;

                    case 2:
                        Console.Write("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат вычитания чисел: " + (a - b));
                        break;

                    case 3:
                        Console.Write("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат умножения чисел: " + (a * b));
                        break;

                    case 4:
                        Console.Write("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат деления чисел: " + (a / b));
                        break;

                    case 5:
                        Console.Write("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат возведения чисел: " + Math.Pow(a, b));
                        break;

                    case 6:
                        Console.Write("Введите число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат квадратного корня: " + Math.Sqrt(a));
                        break;

                    case 7:
                        Console.Write("Введите число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат одного процента: " + (a * 0.01));
                        break;

                    case 8:
                        Console.Write("Введите число: ");
                        BigInteger c = Convert.ToInt32(Console.ReadLine());
                        BigInteger d = 1;
                        for (BigInteger i = c; i >= 1; i--)
                            d *= i;
                        Console.WriteLine("Результат факториала: " + d);
                        break;



                }
            } while (actions != 9);

        }
    }
}