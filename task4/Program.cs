using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            uint leng = uint.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            uint high= uint.Parse(Console.ReadLine());

            Console.Clear();

            for (uint i = leng; i <= high; i++)
            {
                for (uint j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            

            Console.WriteLine();
        }
    }
}

/*Задание 4. 
 Даны целые положительные числа A и B (A < B). Вывести все целые
числа от A до B включительно; каждое число должно выводиться на новой строке;
при этом каждое число должно выводиться количество раз, равное его значению.
*/
