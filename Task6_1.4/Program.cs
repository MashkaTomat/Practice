namespace Task6_1._4
/*
Даны вещественные числа a и b. Определите, принадлежит ли точка с
координатами (a; b) заштрихованной области.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine());

            float x1 = 0, x2 = 2, y1 = 2, y2 = -3, x3 = -2, y3 = -3;

            if (((a - x1) * (y2 - y1) - (x2 - x1) * (b - y1) >= 0 ) && 
               ((a - x2) * (y3 - y2) - (x3 - x2) * (b - y2) >= 0) && 
               (((a - x3) * (y1 - y3) - (x1 - x3) * (b - y3)) >= 0))
            {

                Console.Write("Точка принадлежит данной области.");

            }
            else
            {
                Console.Write("Точка не принадлежит заданной области.");
            }
        }
    }
}
