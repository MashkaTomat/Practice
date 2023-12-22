namespace Task1_1._4
/*
Дано целое положительное число n. Вычислите произведение натуральных
чисел, кратных трём и не превышающим число n.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());//6

            int multiply = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0) //3//6
                {
                    multiply *= i;//3//18
                }
            }

            Console.Write($"Произведение равно: {multiply}.");
        }
    }
}
