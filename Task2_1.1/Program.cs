namespace Task2_1._1
/*
Добавляйте новые числа в список до тех пор, пока пользователь не введет 0.
Выведите в консоль сумму и произведение всех элементов списка. Выведите средннее,
среди всех элементов списка.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            while (true)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp == 0)
                {
                    break;
                }
                else 
                {
                    nums.Add(temp); 
                }
            }

            int sum = 0; //Иначе будет выдавать неверное значение (на +1 больше)
            int multiply = 1;


            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
                multiply *= nums[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(multiply);
            Console.WriteLine($"Среднее арифметическое: {sum / nums.Count}");

        }

    }
}
