namespace Task2_1._5
/*Дан файл numsTask2.txt с вещественными числами, расположенными через
«;». Напишите алгоритм, сортирующий числа по возрастанию. Запишите полученную
отсортированную последовательность обратно в файл;*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] SplitedNums = File.ReadAllText("numsTask2.txt").Split(';');
                float[] Nums = Array.ConvertAll(SplitedNums, Single.Parse);

                float temp;

                for (int i = 0; i < Nums.Length; i++)
                {
                    for (int j = i + 1; j < Nums.Length; j++)
                    {
                        if (Nums[i] > Nums[j])
                        {
                            temp = Nums[i];
                            Nums[i] = Nums[j];
                            Nums[j] = temp;
                        }
                    }
                }

                File.WriteAllText("numsTask2.txt", "");

                for (int i = 0; i < Nums.Length; i++)
                {
                    if (i == Nums[Nums.Length - 1])
                    {
                        File.AppendAllText("numsTask2.txt", Nums[i].ToString());
                    }
                    else
                    {
                        File.AppendAllText("numsTask2.txt", Nums[i] + ";");
                    }
                }
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
