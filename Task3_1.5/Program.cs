namespace Task3_1._5
/*Дан файл numsTask3.txt с целыми числами, вычислите среднее
арифметическое элементов расположенных до минимального*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string[] splitedNums = File.ReadAllText("numsTask3.txt").Split(' ');
            float[] nums = Array.ConvertAll(splitedNums, float.Parse);

            float sum = 0;

            int i = 0;

            for (; i < Array.IndexOf(nums, nums.Min()); i++)
            {
                sum += nums[i];
            }

            if (i == 0)
            {
                sum += nums[i];
                i = 1;
            }

            float average = sum / i;

            Console.WriteLine(average);

        }
    }
}
