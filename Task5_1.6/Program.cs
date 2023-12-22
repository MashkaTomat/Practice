namespace Task5_1._6
/*Дана прямоугольная матрица a, имеющей n строк и m столбцов. Исходная
матрица состоит из нулей и единиц. Добавьте к матрице еще один столбец, каждый
элемент которого делает количество единиц в каждой строке четным;*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и столбцов в матрице:");
            int[,] a = new int[Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())];

            int[,] b = new int[a.GetLength(0), a.GetLength(1) + 1];


            Random rnd = new Random();


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(0, 2);
                    b[i, j] = a[i, j];
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                int TempSum = 0;

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    TempSum += b[i, j];
                }

                if (TempSum % 2 != 0)
                {
                    b[i, b.GetLength(1) - 1] = 1;
                }
            }

            Console.WriteLine($"Содержимое матрицы a:");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n");


            Console.WriteLine($"Содержимое матрицы b:");

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
