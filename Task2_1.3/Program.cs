namespace Task2_1._3
/*
Дан файл(nums.txt), содержащий целые числа, через пробел. Удалите из него
все четные числа.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFromFile = File.ReadAllText("nums.txt");

            string[] nums = textFromFile.Split(' ');


            List<int> oddNums = new List<int>();

            foreach (string num in nums)
            {
                if (Int32.Parse(num) % 2 != 0)
                {
                    oddNums.Add(Int32.Parse(num));
                }
            }

            File.WriteAllText("nums.txt", "");

            foreach (int oddNum in oddNums)
            {
                if (oddNum == oddNums[oddNums.Count - 1])
                {
                    File.AppendAllText("nums.txt", oddNum.ToString());
                }
                else
                {
                    File.AppendAllText("nums.txt", oddNum + " ");
                }

            }
        }
    }
}
