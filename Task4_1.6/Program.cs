namespace Task4_1._6
/*Вводятся положительные числа. Определите сумму чисел, делящихся на
положительное число a нацело. При вводе отрицательного числа закончите работу;*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число a: ");
                float a = float.Parse(Console.ReadLine()), Sum = 0;



                while (true)
                {
                    Console.Write("Введите положительное число: ");

                    float temp = float.Parse(Console.ReadLine());

                    if (temp > 0)
                    {
                        if (temp % a == 0)
                        {
                            Sum += temp;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write($"Сумма всех положительных чисел равна {Sum}");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
