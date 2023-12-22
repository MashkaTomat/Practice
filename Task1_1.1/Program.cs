namespace Task1_1._1
/*
Создайте коллекцию(массив) с 10 случайными числами. Выведите в консоль
номер минимального элемента.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            Random rnd = new Random();

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(-15, 11);
            }

            Console.WriteLine(nums.Min());
        }
    }
}
