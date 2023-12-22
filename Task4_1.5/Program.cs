namespace Task4_1._5
/*Дан файл numsTask4.txt с целыми числами. Вычислите сумму элементов,
отличающихся от максимального на 1*/
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] splitedNums = File.ReadAllText("numsTask4.txt").Split(' ');
                int[] nums = Array.ConvertAll(splitedNums, Int32.Parse);

                int sum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == nums.Max() - 1)
                    {
                        sum += nums[i];
                    }
                }

                Console.WriteLine($"Сумма чисел, отличающихся от максимального на 1, равна {sum}");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
