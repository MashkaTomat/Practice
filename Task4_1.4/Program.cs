namespace Task4_1._4
/*
Дан файл numsTask4.txt с целыми числами, расположенными через пробел.
Определите количество одинаковых рядом стоящих чисел.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string textFromFile = File.ReadAllText("numsTask4.txt");
                string[] nums = textFromFile.Split(' ');

                int numsCount = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != 0 && i != nums.Length - 1)
                    {
                        if (nums[i] == nums[i + 1] || nums[i - 1] == nums[i])
                        {
                            numsCount++;
                        }
                    }
                    else if (i == 0)
                    {
                        if (nums[i] == nums[i + 1])
                        {
                            numsCount++;
                        }
                    }
                    else if (i == nums.Length - 1)
                    {
                        if (nums[i] == nums[i - 1])
                        {
                            numsCount++;
                        }
                    }
                }

                Console.Write(numsCount);
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
