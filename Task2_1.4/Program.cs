namespace Task2_1._4
/*.
Дан файл numsTask2.txt с вещественными числами, расположенными через
«;» Переберите все числа до 0. Определите сумму положительных элементов
получившейся последовательности.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("numsTask2.txt");
            string[] nums = text.Split(';');

            float sum = 0;

            foreach (var Num in nums)
            {
                if (Num == "0")
                {
                    break;
                }

                if (float.Parse(Num) >= 0)
                {
                    sum += float.Parse(Num);
                }
            }

            Console.Write($"Сумма равна: {sum}");
        }
    }
}
