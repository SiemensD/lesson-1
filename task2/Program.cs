using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер трамвайного билета:  ");
            string ticketNumber = Console.ReadLine();

            if (ticketNumber.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < 6; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += Convert.ToInt32(Convert.ToString(ticketNumber)[i].ToString());

                    }
                    else rightNumber += Convert.ToInt32(Convert.ToString(ticketNumber)[i].ToString());
                }
                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
                }

                else Console.WriteLine("У вас не счастливый билет: {0} != {1}", leftNumber, rightNumber);

            }
            else Console.WriteLine("\n\n\t\t\tЧисло введено не правильно!!!\n\t\t\tКоличество цыфр не равно шести!!!\n");

            Console.Read();


        }
    }
}


/*Задание 2. 
Ввести с клавиатуры номер трамвайного билета (6-значное число) 
и проверить является ли данный билет счастливым (если на билете 
напечатано шестизначное число, и сумма первых трёх цифр равна 
сумме последних трёх, то этот билет считается счастливым).*/