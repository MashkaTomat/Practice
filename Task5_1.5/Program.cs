namespace Task5_1._5
/*Дан файл numsTask5.txt с целыми числами. Вычислите среднее
арифметическое элементов расположенных между минимальным и максимальным*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] splitedNums = File.ReadAllText("numsTask5.txt").Split(' ');
            int[] nums = Array.ConvertAll(SplitedNums, Int32.Parse);

            int sum = 0, elementCount = 0;

            if (Array.IndexOf(nums, nums.Min()) < Array.IndexOf(nums, nums.Max()))
            {
                for (int i = Array.IndexOf(nums, nums.Min()) + 1; i < Array.IndexOf(nums, nums.Max()); i++)
                {
                    sum += nums[i];

                    elementCount++;
                }
            }
            else
            {
                for (int i = Array.IndexOf(nums, nums.Max()) + 1; i < Array.IndexOf(nums, nums.Min()); i++)
                {
                    sum += nums[i];

                    elementCount++;
                }
            }

            float average = sum / elementCount;

            Console.WriteLine($"Среднее арифметическое всех чисел, находящихся между минимальным и максимальным числом, равно {average}");
        }
    }
}
