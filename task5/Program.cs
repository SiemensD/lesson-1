using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число: ");
            string str=Console.ReadLine();

            Console.Write("Обратный вывод значения: ");
             for (int i = str.Length - 1; i >= 0; --i)
                Console.Write(str[i]);

            Console.WriteLine();
        }
    }
}
/*Задание 5. 
Дано целое число N (> 0), найти число, полученное при прочтении
числа N справа налево. Например, если было введено число 345, то программа
должна вывести число 543.*/