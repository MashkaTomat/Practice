using System.ComponentModel;

namespace Task1_1._2
/*
Создайте коллекцию(массив) размерностью 100. Добавьте в коллекцию числа
в убывающем порядке, каждое число меньше предыдущего на 3;
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];

            int temp = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                temp -= 3;

                nums[i] = temp;

                Console.WriteLine(nums[i]);
            }

        }
    }
}
