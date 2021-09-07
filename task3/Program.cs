using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char symbolChar = ' ';
            Console.WriteLine("\t\t<<Программа конвертирует маленькие символы в большие и наобарот>>");
            Console.WriteLine("Введите текст:");
            Console.WriteLine("\n");
            while (symbolChar != '.')
            {
                var symbol = Console.Read();

                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                   
                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;                    
                }
                symbolChar = Convert.ToChar(symbol);
                Console.Write(symbolChar);

                
            }
            Console.WriteLine();
          
        }
    }
}
/*Задание 3.
Числовые значения символов нижнего регистра в коде ASCII
отличаются от значений символов верхнего регистра на величину 32. 
Используя эту информацию, написать программу, которая считывает 
с клавиатуры и конвертирует все символы нижнего регистра в 
символы верхнего регистра и наоборот.*/