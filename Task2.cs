using System;
using System.Collections.Generic;

class Task2
{
    //2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    //Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
    //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    //При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

    internal static void Start()
    {
        Console.WriteLine("Введите множество чисел.");
        Console.WriteLine("Чтобы подсчитать сумму всех нечетных положительных чисел введите 0");
        string strNum;
        int summ = 0;
        List<string> numList = new List<string>();
        int num;
        do
        {
            strNum = Console.ReadLine();
            if (Int32.TryParse(strNum, out num) && num % 2 == 1 && num > 0)
            {
                summ += num;
                numList.Add(strNum);
            }
            else if (!Int32.TryParse(strNum, out num))
            {
                Console.WriteLine("Строка не является числом");
            }
        } while (num != 0 || !Int32.TryParse(strNum, out num));

        Console.Write($"Сумма чисел (");
        int i = 0;
        while (i < numList.Count)
        {
            Console.Write($" {numList[i]}");
            if ( i < numList.Count - 1)
            {
                Console.Write(",");
            }
            i++;
        }
        Console.WriteLine($" ) равна: {summ}");
        Console.ReadKey();
    }
}
