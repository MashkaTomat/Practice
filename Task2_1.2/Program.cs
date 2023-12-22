namespace Task2_1._2
/*
Заполните массив последовательными нечетными числами, начиная с 1.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];

            for (int i = 1; i < nums.Length; i += 2)
            {
                nums[i] = i;

                Console.WriteLine("Нечётное число = " + nums[i]);

            }
        }
    }
}
