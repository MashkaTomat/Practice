namespace Task6_1._6
/*Дан массив со случайным количеством дробных чисел. Из элементов
исходного массива постройте два новых. В первый должны входить только
положительные элементы, а во второй только отрицательные элементы*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] nums = new float[20];

            Random rnd = new Random();

            List<float> positiveNums = new List<float>();
            List<float> negativeNums = new List<float>();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.NextSingle() + rnd.Next(-100, 100);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    positiveNums.Add(nums[i]);
                }
                else
                {
                    negativeNums.Add(nums[i]);
                }
            }


            Console.WriteLine($"Положительные числа:");

            for (int i = 0; i < positiveNums.Count; i++)
            {
                Console.WriteLine(positiveNums[i]);
            }


            Console.WriteLine($"\n\nОтрицательные числа:");

            for (int i = 0; i < negativeNums.Count; i++)
            {
                Console.WriteLine(negativeNums[i]);
            }
        }
    }
}
