namespace Task3_1._2
/*
Заполните квадратную матрицу n x n так, чтобы все числа первого столбца и
первой строки равны 1, а каждое из оставшихся чисел равно сумме верхнего и левого
соседей. Выведите на экран получившеюся матрицу.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] nums = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                nums[0, i] = 1;//0 - столбец, i - строка.
                nums[i, 0] = 1;
            }

            for (int i = 1; i < n; i++)//столбцы
            {
                for (int j = 1; j < n; j++)//строки
                {
                    nums[i, j] = nums[i, j - 1] + nums[i - 1, j];
                }

                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(nums[i, j] + "   ");
                }

                Console.WriteLine();
            }
        }
    }
}
