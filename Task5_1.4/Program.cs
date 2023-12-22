namespace Task5_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine());

            if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }
        }
    }
}
