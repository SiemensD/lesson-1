using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            char str;
            int counter = 0;
            do
            {
                str = Console.ReadKey().KeyChar;
                if (str == ' ')
                    counter++;
            }
            while (str != '.');



            Console.WriteLine("\n\n Количество пробелов: " + counter);

        }
    }
}
/*Задание 1.
   Написать программу, которая считывает символы с клавиатуры, пока не
будет введена точка. Программа должна сосчитать количество введенных
пользователем пробелов. */