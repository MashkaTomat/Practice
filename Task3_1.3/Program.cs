namespace Task3_1._3
/*
Дан файл, содержащий несколько целых чисел количеством i. Создайте
массив height длиной i. Каждый элемент массива это вертикальная линия определенной
длины. Найдите две линии, которые вместе с осью x образуют контейнер, содержащий
наибольшее количество воды.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            Random rnd = new Random();

            int max = 0;

            int temp;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 51); //высота стенки резервуара
            }

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        if (Array.IndexOf(nums, nums[i]) > Array.IndexOf(nums, nums[j]))
                        {
                            temp = nums[i] * (Array.IndexOf(nums, nums[i]) - Array.IndexOf(nums, nums[j]));//расстрояние от одной стенки к др
                        }
                        else
                        {
                            temp = nums[i] * (Array.IndexOf(nums, nums[j]) - Array.IndexOf(nums, nums[i]));
                        }

                    }
                    else
                    {
                        if (Array.IndexOf(nums, nums[i]) > Array.IndexOf(nums, nums[j]))
                        {
                            temp = nums[j] * (Array.IndexOf(nums, nums[i]) - Array.IndexOf(nums, nums[j]));
                        }
                        else
                        {
                            temp = nums[j] * (Array.IndexOf(nums, nums[j]) - Array.IndexOf(nums, nums[i]));
                        }
                    }

                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }

            File.WriteAllText("Output.txt", max.ToString());
        }
    }
}
