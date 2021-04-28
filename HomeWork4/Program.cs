using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int OddNumbersCount = 0;
            int EvenNumbersCount = 0;

            int OddNumbersSum = 0;
            int EvenNumbersSum = 0;

            Console.WriteLine("Введите первое число, диапазон которого будет расчитываться");
            int FirstCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число, диапазон которого будет расчитываться");
            int limit = int.Parse(Console.ReadLine());
            while (FirstCount <= limit)
            {
                if (FirstCount % 2 == 0)
                {
                    EvenNumbersSum += FirstCount;
                    EvenNumbersCount++;
                }
                else
                {
                    OddNumbersSum = OddNumbersSum + FirstCount;
                    OddNumbersCount++;
                }
                FirstCount++;
            }

                Console.WriteLine("Количество четных чисел: " + EvenNumbersCount);
                Console.WriteLine("Количество нечетных чисел: " + OddNumbersCount);
                Console.WriteLine("Сумма четных чисел: " + EvenNumbersSum);
                Console.WriteLine("Сумма нечетных чисел: " + OddNumbersSum);
                Console.ReadLine();
        }
    }
}
