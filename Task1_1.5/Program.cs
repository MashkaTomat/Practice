namespace Task1_1._5
    /*Дан файл numsTask1.txt с целыми числами, вычислите произведение
элементов расположенных после минимального.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string[] splitNums = File.ReadAllText("numsTask1.txt").Split(' ');

                int[] nums = Array.ConvertAll(splitNums, int.Parse);

                int sum = 0;

                for (int i = Array.IndexOf(nums, nums.Min()); i < nums.Length; i++)
                {
                    sum += nums[i];
                }

                Console.WriteLine($"Сумма всех элементов равна {sum}");

            }

            catch (IOException ex)

            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
